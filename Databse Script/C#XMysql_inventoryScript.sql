drop database if exists `project_blue`;
create database `project_blue`;
use `project_blue`;

create table `user_info`( /*for both the customers and the restaurant managers*/
	user_id int not null auto_increment,
    account_type varchar(255) not null,
    full_name varchar(255) not null,
    email varchar(255) not null unique,
    username varchar(255) not null unique,
    _password varchar(255),
    primary key(user_id)
);

create table `restaurant_manager`(
	full_name varchar(255) not null,
    rid int
);

create table `offerings`(
	offering_id int not null auto_increment,
    rid int,
    offering_name varchar(255) not null,
    offering_image longblob not null,
    price float not null,
    offering_type varchar(255), /*breakfast, lunch, dinner*/
    cuisine varchar(255) , /*American, Indian, chinese*/
    course_of_meal varchar(255) , /* Main dishes(Entrees), appetizers, deserts*/
    EWT varchar(255) , /*Estimated waiting time*/
    ETA varchar(255) , /*Estimaated time of arrival when asked to deliver*/
	service_options varchar(255) not null,
    primary key(offering_id)
);

create table `restaurant`(
	restaurant_id int not null auto_increment,
    address varchar(255),
    address_on_map varchar(2083) not null,
    restaurant_name varchar(255) not null, 
    restaurant_image longblob not null,
    phone_number varchar(255),
    opening_and_closing_time varchar(255),
	service_options varchar(255) not null,
    primary key(restaurant_id)
);

create table `favourites`(
        full_name varchar(255) not null,
        offering_name varchar(255) not null,
		offering_image longblob not null,
		price float not null
);


create table `orders`(
        full_name varchar(255) not null,
        offering_name varchar(255) not null,
		restaurant_name varchar(255) not null, /*The restaurant where the meal is served*/
        offering_image longblob not null,
		offering_type varchar(255) /*breakfast, lunch, dinner, dessert*/
);

drop table `restaurant`;

delete from `restaurant_manager`; 

select * from `user_info`;

select * from `restaurant`;

select * from `restaurant_manager`;

select restaurant_id, restaurant_name from restaurant;

update `restaurant`
set address = 'In front of sunshine construction'
where restaurant_id = 1;



insert into `restaurant_manager` values ('Abel Kassahun', 1);

insert into `restaurant_manager` values ('Eyob Gebreselassie', 2);

