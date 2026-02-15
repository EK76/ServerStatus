# Server Status
This project is done with help of Visual Studio C#. Purpose for this project is to monitor both the computer's CPU 
and harddisk temperature when using a Linux operatingsystem. In my case I used the Ubuntu 25.04 LTS. 
You should also be able to use any kind of the most common Linux operating system for this purpose, but I have only tested on Ubuntu
and Debian. It is also possible to check when the Linux computer have been last rebooted. It stores 20 most recent reboot times.

You need to install smartmontools and use the harddisk's device path which in my case is 	**/dev/nvme0n1p3**
for reading the harddisk's temperature. The read the cpu's temperature you use this simple command, 	**cat "/sys/class/thermal/thermal_zone0/temp**
This command may be different in other linux operating system. Check your Linux operatingssystem' user guide for the right command.

For checking the both cpu's and harddisk'a temperatures I created this bash script. The bash script alsp store
the temperature values into a MySQL table.

```console
cpu=$(cat "/sys/class/thermal/thermal_zone0/temp")
cpu=$(echo "scale=2 ; $cpu / 1000" | bc)
harddisk=$(sudo smartctl -A /dev/nvme0n1p3 | grep -i temperature | head -n 1)
harddisk=$(echo $harddisk | grep -o -P '(?<=Temperature: ).*(?=Celsius)')

mysql --user=pcuser --password=**** \-e "insert into serverpcstatus.infostatus (cpustatus,hdstatus) values ('${cpu}','${harddisk}');"
mysql --user=pcuser --password=**** \-e "delete from serverpcstatus.infostatus where id not in (select id from(select id from serverpcstatus.infostatus order by id desc limit 90)info);"
```
This bash script check the Linux reboot and store the value into a MySQL table.

```console
updatestatus=$(uptime -s)
mysql --user=pcuser --password=Test0880! \-e "insert into serverpcstatus.systemstatus(datecreated) values ('${updatestatus}');"
mysql --user=pcuser --password=Test0880! \-e "delete from serverpcstatus.systemstatus where id not in (select id from(select id from serverpcstatus.systemstatus order by id desc limit 20)info);"
```
In order to use this application, you must create following database and tables according to the directive below.
MySQL have been chosen as database language for this project.
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
Description of the tables.
```
mysql> desc infostatus;
+-------------+---------------+------+-----+---------+-------------------+
| Field       | Type          | Null | Key | Default | Extra             |
+-------------+---------------+------+-----+---------+-------------------+
| id          | int           | NO   | PRI | NULL    | auto_increment    |
| cpustatus   | decimal(10,2) | YES  |     | NULL    |                   |
| datecreated | datetime      | YES  |     | now()   | DEFAULT_GENERATED |
| hdstatus    | decimal(10,2) | YES  |     | NULL    |                   |
+-------------+---------------+------+-----+---------+-------------------+
9 rows in set (0.00 sec)

mysql> desc systemstatus;
+-------------+----------+------+-----+---------+----------------+
| Field       | Type     | Null | Key | Default | Extra          |
+-------------+----------+------+-----+---------+----------------+
| id          | int      | NO   | PRI | NULL    | auto_increment |
| dateupdated | datetime | YES  |     | NULL    |                |
+-------------+----------+------+-----+---------+----------------+
2 rows in set (0.00 sec)
```

After creation of database and tables are done.
Edit configdb.txt file with the correct info about your MySQL credentials with text editor of your choosing.
Compaile or publish the project with Visual Studio 2022 to test it.

I have also installed MySql.Data plugin from Oracle Corporation trough Visual Studio NuGet Package Manager
when I developed this project. MySql.Data makes it easier to read from and make changes to MySQL database when
using Visual Studio.

**Two pictures of the application.** <br />
<img width="442" height="968" alt="image" src="https://github.com/user-attachments/assets/e9513558-411d-433d-bc93-c866a0f2672a" />
<img width="2517" height="1197" alt="image" src="https://github.com/user-attachments/assets/cf93d048-e6d2-4884-8a9a-2c8c5fbd67b0" />



**How to clone this repository with git.**
https://github.com/EK76/ServerStatus.git<br/><br/>
If you discover any fault or inaccurate information, feel free to contact me trough epost address: ken.ekholm@live.com
