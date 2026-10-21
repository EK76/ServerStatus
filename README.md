# Server Status
The purpose of this project is to monitor a Linux computer's CPU temperature and hard disk temperature using a Visual Studio 2022 C# application.
In my setup, the monitored system runs Ubuntu 25.10, although the project should work with most common Linux distributions. The project has been tested on Ubuntu and Debian.
Temperature data is collected automatically and stored in a MySQL/MariaDB database for historical analysis and monitoring. 

In my implementation, a scheduled task created with cron (crontab) stores temperature readings every two hours. More information about cron jobs can be found in this guide. [https://cr.../cron-jobs]
The database retains the 90 most recent temperature records, automatically removing older entries as new data is added. In addition to temperature monitoring, the project can track system uptime 
by recording when the Linux computer was last rebooted. The system stores the 20 most recent reboot events in a separate MySQL/MariaDB table, making it possible to review the reboot history of the monitored device.


#### Visual Studio C# project requirements.
- .NET 9.0
-  C# language version 13.0

To read the hard disk temperature, you must install smartmontools on the Linux system. The command uses the hard disk's device path, which in my case is /dev/nvme0n1p3. 
Depending on the storage device and Linux distribution, your device path may be different.
To read the CPU temperature, I used the following command: **cat /sys/class/thermal/thermal_zone0/temp**

This command reads the current CPU temperature from the Linux thermal subsystem. Please note that the location of temperature sensors may vary between Linux distributions 
and hardware platforms. Consult your Linux distribution's documentation for the appropriate method if this command does not work on your system.
For checking the both cpu's and harddisk'a temperatures I created this bash script. The bash script also store
the temperature values into a MySQL table.

```console
cpu=$(cat "/sys/class/thermal/thermal_zone0/temp")
cpu=$(echo "scale=2 ; $cpu / 1000" | bc)
harddisk=$(sudo smartctl -A /dev/nvme0n1p3 | grep -i temperature | head -n 1)
harddisk=$(echo $harddisk | grep -o -P '(?<=Temperature: ).*(?=Celsius)')

mysql --user=pcuser \-e "insert into serverpcstatus.infostatus (cpustatus,hdstatus) values ('${cpu}','${harddisk}');"
mysql --user=pcuser \-e "delete from serverpcstatus.infostatus where id not in (select id from(select id from serverpcstatus.infostatus order by id desc limit 90)info);"
```
This bash script check the Linux reboot time and store the value into a MySQL table.

```console
updatestatus=$(uptime -s)
mysql --user=pcuser \-e "insert into serverpcstatus.systemstatus(datecreated) values ('${updatestatus}');"
mysql --user=pcuser \-e "delete from serverpcstatus.systemstatus where id not in (select id from(select id from serverpcstatus.systemstatus order by id desc limit 20)info);"
```
As you can see in my both bash scripts I have left out the mysql password. It was possible to do so, because I created ~/.my.cnf file under my Home folder
with following content. 
##### my.cnf file's content.
```
[client]
user=myuser
# Your MySQL username.
password=mypassword
# Your password to the MySQL username.
```
Remember to make it only accessible by yourself with permission chmod 600, so no other user can use the file.

In order to use this application, you must create following database and tables according to the directive below.<br />
The MySQL version 8.4.8-0ubuntu0.25.10.1 acts as my database server for this project.
```
create database serverpcstatus;
use serverpcstatus;

create table infostatus3(
id int not null auto_increment,
cpustatus decimal(10,2),
hdstatus decimal(10,2),
datecreated datetime default (current_timestamp),
primary key(id)
);

create table systemstatus( 
id int not null auto_increment, 
dateupdated datetime, 
primary key(id)
);
```
Edit configdb.txt file within this Visual Studio C# project with the correct info about your MySQL credentials with text editor of your choosing.

During the development of this project, I installed the MySql.Data package from Oracle Corporation through the Visual Studio NuGet Package Manager.
The MySql.Data package provides a .NET data provider for MySQL databases and simplifies database operations within the Visual Studio C# application.

**Two pictures of the application.** <br />
<img width="442" height="968" alt="image" src="https://github.com/user-attachments/assets/e9513558-411d-433d-bc93-c866a0f2672a" />
<img width="2517" height="1197" alt="image" src="https://github.com/user-attachments/assets/cf93d048-e6d2-4884-8a9a-2c8c5fbd67b0" />
