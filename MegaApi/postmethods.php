<?php


function authorization($connect, $data){
    $Emloyers=$connect->prepare("select * from Employees where Email=? and Password=?");
    $Emloyers->execute(array(strval($data["email"]), md5(strval($data["password"]) )));
    $listUser=$Emloyers->fetchAll();
    //echo md5(strval($data["password"]) ); die();
    if(count($listUser)==0){
        $responce=[
            "status"=>false,
            "message"=>"user not found!"
        ];
        http_response_code(404);
    }
    else{
 
      //  print_r($listUser); die();
        $responce=[
            "status"=>true,
            "message"=>"Authorizated!",
            "surname"=>$listUser[0]["Surename"],
            "firstname"=>$listUser[0]["LastName"],
            "name"=>$listUser[0]["Name"],
            "position"=>$listUser[0]["Position"],
            "employer_id"=>$listUser[0]["ID_Employees "]
        ];
        http_response_code(200);
    }
    echo json_encode($responce);
 }




 function updateEmploye($connect, $data){
    try{

        //var_dump($data);
        //print_r($data);die();
        $selectPosts=$connect->prepare("UPDATE `Employees` SET `Surename`=?,`Name`=?,`LastName`=?,`PasportNumber`=?,`PasportSiries`=?,`Snils`=?,`Position`=?, `Salary`=? WHERE `ID_Employees`=?");
        $selectPosts->execute(array(
            strval($data["middlename"]),
            strval($data["firstname"]),
            strval($data["lasttname"]),
            strval($data["passportNumber"]),
            strval($data["passportSiries"]),
            strval($data["snils"]),
            $data["position"],
            $data["salary"],
            $data["id_employer"],
            )
        );
        $responce=[
         "status"=>true,
         "message"=>"employer updated"
        ];
        echo json_encode($responce);
    } catch (PDOException $e) {
         $responce=[
            "status"=>false,
            "message"=>"employe not updated"
        ];
        echo json_encode($responce);
    }
}

function deleteOrder($connect, $data){
    //  echo $data["email"]; die();
      try{
       // print_r($data);
          $deleteUser =$connect->prepare("DELETE FROM `Order` WHERE ID_Order=?");
          $deleteUser ->execute(array(
            $data["id"]
        ));

        $responce=[
            "status"=>true,
            "message"=>"order was deleted"
        ];
        echo json_encode($responce);
        }
        catch (Exception $e){
          $responce=[
              "status"=>false,
              "message"=>"order wasn't deleted"
          ];
          echo json_encode($responce);
      }
  
     
  }


function updateOrder($connect, $data){
    //  echo $data["email"]; die();
      try{
       // print_r($data);
          $deleteUser =$connect->prepare("UPDATE `Order` SET `Status`=? WHERE ID_Order=?");
          $deleteUser ->execute(array(
            strval($data["status"]),
            $data["id"]
        ));
        $responce=[
            "status"=>true,
            "message"=>"order was updated"
        ];
        echo json_encode($responce);
        }
        catch (Exception $e){
          $responce=[
              "status"=>false,
              "message"=>"order wasn't updated"
          ];
          echo json_encode($responce);
      }
  
     
  }

  function createIngridient($connect, $data){
    //  echo $data["email"]; die();
      try{
     //   print_r($data);
          $deleteUser =$connect->prepare("INSERT INTO `Ingredients`( `NameIngredients`) VALUES (?)");
          $deleteUser ->execute(array(
            strval($data["name"])
        ));
        $responce=[
            "status"=>true,
            "message"=>"ingridient was created",
            "id"=>$connect->lastInsertId()
        ];
        echo json_encode($responce);
        }
        catch (Exception $e){
          $responce=[
              "status"=>false,
              "message"=>"ingridient wasn't created"
          ];
          echo json_encode($responce);
      }
  
     
  }


  function createDish($connect, $data){
    //  echo $data["email"]; die();
      try{
     //   print_r($data);
          $deleteUser =$connect->prepare("INSERT INTO `Dishes`( `NameDishes`, `Cost`, `Weight`) VALUES (?,?,?)");
          $deleteUser ->execute(array(
            strval($data["name"]),
            strval($data["cost"]),
            strval($data["weight"])
        ));
        $responce=[
            "status"=>true,
            "message"=>"ingridient was created",
            "id"=>$connect->lastInsertId()
        ];
        echo json_encode($responce);
        }
        catch (Exception $e){
          $responce=[
              "status"=>false,
              "message"=>"ingridient wasn't created"
          ];
          echo json_encode($responce);
      }
  
     
  }





  function updateIngridient($connect, $data){
    //  echo $data["email"]; die();
      try{
       // print_r($data);
          $deleteUser =$connect->prepare("UPDATE `Ingredients` SET `NameIngredients`=? WHERE `ID_Ingredients`=?");
          $deleteUser ->execute(array(
            strval($data["name"]),
            $data["id"]
        ));
        $responce=[
            "status"=>true,
            "message"=>"ingridient was updated"
        ];
        echo json_encode($responce);
        }
        catch (Exception $e){
          $responce=[
              "status"=>false,
              "message"=>"ingridient wasn't updated"
          ];
          echo json_encode($responce);
      }
  
     
  }


  function updateDish($connect, $data){
    //  echo $data["email"]; die();
      try{
       // print_r($data);
          $deleteUser =$connect->prepare("UPDATE `Dishes` SET `NameDishes`=?,`Cost`=?,`Weight`=? WHERE `ID_Dishes`=?");
          $deleteUser ->execute(array(
            strval($data["name"]),
            strval($data["cost"]),
            strval($data["weight"]),
            $data["id"]
        ));
        $responce=[
            "status"=>true,
            "message"=>"dish was updated"
        ];
        echo json_encode($responce);
        }
        catch (Exception $e){
          $responce=[
              "status"=>false,
              "message"=>"dish wasn't updated"
          ];
          echo json_encode($responce);
      }
  
     
  }



  function updateWareHouse($connect, $data){
    //  echo $data["email"]; die();
      try{
       // print_r($data);
          $deleteUser =$connect->prepare("UPDATE `Warehouse` SET `Cells`=?,`Amount`=?,`Adres`=? WHERE `ID_Warehouse`=?");
          $deleteUser ->execute(array(
            strval($data["cells"]),
            strval($data["amount"]),
            strval($data["adres"]),
            $data["id"]
        ));
        $responce=[
            "status"=>true,
            "message"=>"dish was updated"
        ];
        echo json_encode($responce);
        }
        catch (Exception $e){
          $responce=[
              "status"=>false,
              "message"=>"dish wasn't updated"
          ];
          echo json_encode($responce);
      }
  
     
  }

  function updateSupply($connect, $data){
    //  echo $data["email"]; die();
      try{
       // print_r($data);
          $deleteUser =$connect->prepare("UPDATE `Supply` SET `Provider`=?,`DateSupply`=?,`CostSupply`=? WHERE `ID_Supply`=?");
          $deleteUser ->execute(array(
            strval($data["provider"]),
            strval($data["date"]),
            strval($data["cost"]),
            $data["id"]
        ));
        $responce=[
            "status"=>true,
            "message"=>"dish was updated"
        ];
        echo json_encode($responce);
        }
        catch (Exception $e){
          $responce=[
              "status"=>false,
              "message"=>"dish wasn't updated"
          ];
          echo json_encode($responce);
      }
  
     
  }



  function removeWareHouse($connect, $data){
    //  echo $data["email"]; die();
      try{
          $deleteUser =$connect->prepare("DELETE FROM `Warehouse` WHERE ID_Warehouse=?");
          $deleteUser ->execute(array($data["id"]));
  
          
      } catch (Exception $e){
          $responce=[
              "status"=>false,
              "message"=>"user not deleted"
          ];
          echo json_encode($responce);
      }
  
     
  }


  function removeSupply($connect, $data){
    //  echo $data["email"]; die();
      try{
          $deleteUser =$connect->prepare("DELETE FROM `Supply` WHERE ID_Supply=?");
          $deleteUser ->execute(array($data["id"]));
  
          
      } catch (Exception $e){
          $responce=[
              "status"=>false,
              "message"=>"user not deleted"
          ];
          echo json_encode($responce);
      }
  
     
  }



function removeEployer($connect, $data){
    //  echo $data["email"]; die();
      try{
          $deleteUser =$connect->prepare("DELETE FROM `Employees` WHERE ID_Employees=?");
          $deleteUser ->execute(array($data["id"]));
  
          $selectUsers=$connect->prepare("Select * from Employees where ID_Employees=?");
          $selectUsers->execute(array(strval($data["id"])));
          if(count($selectUsers->fetchAll())>0){
              $responce=[
                  "status"=>false,
                  "message"=>"user not deleted"
              ];
              echo json_encode($responce);
              die();
          }else{
              $responce=[
                  "status"=>false,
                  "message"=>"user deleted"
              ];
              echo json_encode($responce);
              die();
          }
      } catch (Exception $e){
          $responce=[
              "status"=>false,
              "message"=>"user not deleted"
          ];
          echo json_encode($responce);
      }
  
     
  }


  function createSupply($connect, $data){
    //  echo $data["email"]; die();
      try{
     //   print_r($data);
          $deleteUser =$connect->prepare("INSERT INTO `Supply`(`Provider`, `DateSupply`, `CostSupply`, `Warehouse_ID`) VALUES (?,?,?,?)");
          $deleteUser ->execute(array(
            strval($data["provider"]),
            strval($data["date"]),
            strval($data["cost"]),
            strval($data["warehouse_id"])    
        ));
        $responce=[
            "status"=>true,
            "message"=>"ingridient was created",
            "id"=>$connect->lastInsertId()
        ];
        echo json_encode($responce);
        }
        catch (Exception $e){
          $responce=[
              "status"=>false,
              "message"=>"ingridient wasn't created"
          ];
          echo json_encode($responce);
      }
  
     
  }

  function createWareHouse($connect, $data){
    //  echo $data["email"]; die();
      try{
     //   print_r($data);
          $deleteUser =$connect->prepare("UPDATE `Warehouse` SET `Cells`=?,`Amount`=?,`Adres`=? WHERE `ID_Warehouse`=?");
          $deleteUser ->execute(array(
            strval($data["cells"]),
            strval($data["amount"]),
            strval($data["adres"])
        ));
        $responce=[
            "status"=>true,
            "message"=>"ingridient was created",
            "id"=>$connect->lastInsertId()
        ];
        echo json_encode($responce);
        }
        catch (Exception $e){
          $responce=[
              "status"=>false,
              "message"=>"ingridient wasn't created"
          ];
          echo json_encode($responce);
      }
  
     
  }









  function createEmploye ($connect, $data){

    //var_dump($data); die();
    // print_r( $data); die();
     try{



         $createEmploye=$connect->prepare(
         "insert into Employees (Surename,Name,LastName,PasportNumber,PasportSiries,Snils,Position,Salary, Email, Password)
         values (?,?,?,?,?,?,?,?,?,?)"
         );
         
         //if(empty($data["middlename"])) $data["middlename"]="-";
         $createEmploye->execute(array(
            strval($data["middlename"]),
            strval($data["firstname"]),
            strval($data["lastname"]),
            strval($data["passportNumber"]),
            strval($data["passportSiries"]),
            strval($data["snils"]),
            $data["position"],
            $data["salary"],
            $data["email"],
            md5(strval($data["password"]))
         ));
         //print_r($data); die();
         $responce=[
             "status"=>true,
             "message"=>"user created"
         ];
         echo json_encode($responce);
         //die();
         
        // exit();
         //$addedEmploye=$createEmploye->fetchAll();
     } catch (PDOException $e) {
          $responce=[
             "status"=>false,
             "message"=>"user not created"
        ];
         echo json_encode($responce);
    }

}
  
