<?php

function getDishes($connect){
    try{
    $search=$connect->prepare("SELECT * from `Dishes`;");
    $search->execute();
    $list=$search->fetchAll();

    echo json_encode($list);
 } catch (PDOException $e){
    http_response_code(404);
 }

}


function getDumps($connect){

   $dumpsList= array();
   $dir = '../backupFiles/'; // Папка с дампами на сервере
   $f = scandir($dir);
   foreach ($f as $file){
      if(preg_match('/\.(sql)/', $file))
         $dumpsList[]= substr($file, 0, -4); 
   }
   echo json_encode($dumpsList);
}


function getEmployees($connect){
   try{
      $searchUser=$connect->prepare("SELECT `ID_Employees`, `Surename`, `Name`, `LastName`, `PasportNumber`, `PasportSiries`, `Snils`, `Position`, `Salary`, `Email` FROM `Employees` ");
      $searchUser->execute();
      $listUser=$searchUser->fetchAll();
  
      echo json_encode($listUser);
   } catch (PDOException $e){
      http_response_code(404);
   }
}

function getOrders($connect){
   try{
      $searchUser=$connect->prepare("SELECT * FROM `Order`");
      $searchUser->execute();
      $listUser=$searchUser->fetchAll();
  
      echo json_encode($listUser);
   } catch (PDOException $e){
      http_response_code(404);
   }


}

function getDishesInOrders($connect){
   try{
      $searchUser=$connect->prepare("SELECT * FROM `DishesInOrder`");
      $searchUser->execute();
      $listUser=$searchUser->fetchAll();
  
      echo json_encode($listUser);
   } catch (PDOException $e){
      http_response_code(404);
   }


}
