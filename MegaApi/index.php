<?php
require "connect.php";
require "restore.php";
require "getmethods.php";
require "postmethods.php";
require "createmethods.php";
$params=explode('/', $_SERVER["PATH_INFO"]);
//echo $params[1]; die();
switch ($_SERVER['REQUEST_METHOD']){
    case "POST":{

        switch ($params[1]){
            case "createbackup": createbackup(); break;
            case "executebackup": executebackup($_POST); break;
            case "createOrder": createOrder($connect,$_POST); break;
            case "createDishesInOrder": createDishesInOrder($connect,$_POST); break;
            case "authorization": authorization($connect, $_POST); break;
            case "updateEmploye": updateEmploye($connect, $_POST); break;
            case "removeEployer": removeEployer($connect, $_POST); break;
            case "createEmploye": createEmploye($connect, $_POST); break;
            case "updateOrder": updateOrder($connect, $_POST); break;
            case "deleteOrder": deleteOrder($connect, $_POST); break;
            case "updateIngridient": updateIngridient($connect, $_POST); break;
            case "createIngridient": createIngridient($connect, $_POST); break;
            case "createDish": createDish($connect, $_POST); break;
            case "updateDish": updateDish($connect, $_POST); break;
            case "createDeliverIngridients": createDeliverIngridients($connect, $_POST); break;
            case "createSupply": createSupply($connect, $_POST); break;
            case "createWareHouse": createWareHouse($connect, $_POST); break;
            case "updateWareHouse": updateWareHouse($connect, $_POST); break;
            case "updateSupply": updateSupply($connect, $_POST); break;
            case "removeSupply": removeSupply($connect, $_POST); break;
            case "removeWareHouse": removeWareHouse($connect, $_POST); break;
        }
    }
    break;
    case "GET":{
        switch ($params[1]){
            case "getDishes": getDishes($connect); break;
            case "getDumps": getDumps($connect); break;
            case "getEmployees": getEmployees($connect); break;
            case "getOrders": getOrders($connect); break;
            case "getDishesInOrders": getDishesInOrders($connect); break;
            case "getIngridients": getIngridients($connect); break;
            case "getWarehouses": getWarehouses($connect); break;
            case "getSupplies": getSupplies($connect); break;
        }

    }

}