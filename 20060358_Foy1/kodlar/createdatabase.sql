--veritabaný oluþturma
create database vtyslabodev on primary
(
NAME= vtys_data,
FILENAME = "C:\Users\zynps\Desktop\vtyslabodev\vtysdata.mdf",
SIZE = 8MB,
MAXSIZE = unlimited,
FILEGROWTH = 10%
)
LOG ON
(
NAME= vtys_log,
FILENAME = "C:\Users\zynps\Desktop\vtyslabodev\vtyslog.ldf",
SIZE = 8MB,
MAXSIZE = unlimited,
FILEGROWTH = 10%
)
