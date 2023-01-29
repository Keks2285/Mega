<?php

function createOrder($connect, $data){
    try{
        //print_r($data["listdishes"]);die();

        $createEmploye=$connect->prepare(
        "INSERT INTO `Order`( `TableNumber`, `DateOrder`, `Cost`, `Status`) VALUES (?,?,?,?)"
        );
        
        //if(empty($data["middlename"])) $data["middlename"]="-";
        $createEmploye->execute(array(
            $data["tablenumber"],
            $data["dateorder"],
            $data["cost"],
            "Оформлен"
        ));
        $lastinsertOrder=$connect->lastInsertId();
        $responce=[
            "status"=>true,
            "message"=>"Order created",
            "id"=>$lastinsertOrder
        ];
        echo json_encode($responce);
        //var_dump($data); die();
       // exit();
        //$addedEmploye=$createEmploye->fetchAll();
    } catch (PDOException $e) {
         $responce=[
            "status"=>false,
            "message"=>"Order not created"
        ];
        echo json_encode($responce);
    }
}

function createDishesInOrder($connect, $data){
    try{

        //var_dump($data);die(0);
        $createEmploye=$connect->prepare(
        "INSERT INTO `DishesInOrder`( `Dishes_ID`,`Order_ID`) VALUES (?,?)"
        );
        
        //if(empty($data["middlename"])) $data["middlename"]="-";
        $createEmploye->execute(array(
            $data["dish_id"],
            $data["order_id"]
        ));
        $lastinsertOrder=$connect->lastInsertId();
        $responce=[
            "status"=>true,
            "message"=>"DishesInOrder created"
        ];
        echo json_encode($responce);
        //var_dump($data); die();
       // exit();
        //$addedEmploye=$createEmploye->fetchAll();
    } catch (PDOException $e) {
         $responce=[
            "status"=>false,
            "message"=>"DishesInOrder not created"
        ];
        echo json_encode($responce);
    }
}


function createDeliverIngridients($connect, $data){
    try{

        //var_dump($data);die(0);
        $createEmploye=$connect->prepare(
        "INSERT INTO `DeliveryIngredients`( `Ingredients_ID`, `Supply_ID`) VALUES (?,?)"
        );
        
        //if(empty($data["middlename"])) $data["middlename"]="-";
        $createEmploye->execute(array(
            $data["ingredients_id"],
            $data["supply_id"]
        ));
        $lastinsertOrder=$connect->lastInsertId();
        $responce=[
            "status"=>true,
            "message"=>"DishesInOrder created"
        ];
        echo json_encode($responce);
        //var_dump($data); die();
       // exit();
        //$addedEmploye=$createEmploye->fetchAll();
    } catch (PDOException $e) {
         $responce=[
            "status"=>false,
            "message"=>"DishesInOrder not created"
        ];
        echo json_encode($responce);
    }
}