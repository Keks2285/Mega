<?php

function createbackup(){
    $datename=date('Y.m.d.H-i-s');
    $connect= mysqli_connect('localhost','root','','restoran');
    $tables = array(
        "Categories",
        "Employees",
        "Dishes",
        "Order",
        "Ingredients",
        "DishesInCategory",
        "IngredientsInADish",
        "Warehouse",
        "Supply",
        "DishesInOrder"
    );
    // $result = mysqli_query($connect,"SHOW TABLES");
    // while($row = mysqli_fetch_row($result)){
    // $tables[] = $row[0];
    // }

    $return = '';
    foreach($tables as $table){
    $result = mysqli_query($connect,"SELECT * FROM "."`$table`");
    $num_fields = mysqli_num_fields($result);
    //if($table=="Order"){
    //  echo "result.num_fields;die()";die();
    //}
   // $return .= 'DROP TABLE '.$table.';';
    $row2 = mysqli_fetch_row(mysqli_query($connect,"SHOW CREATE TABLE "."`$table`"));
    $return .= "\n".$row2[1].";\n";
    for($i=0;$i<$num_fields;$i++){
        while($row = mysqli_fetch_row($result)){
          $return .= "INSERT INTO ".$table." VALUES(";
          for($j=0;$j<$num_fields;$j++){
            $row[$j] = addslashes($row[$j]);
            if(isset($row[$j])){ $return .= '"'.$row[$j].'"';}
            else{ $return .= '""';}
            if($j<$num_fields-1){ $return .= ',';}
          }
          $return .= ");\n";
        }
      }
      
      
    }
    //save file
    $handle = fopen("../backupFiles/".$datename.".sql","w+");
    fwrite($handle,$return);
    fclose($handle);
    echo $datename;

}



function executebackup($data)
{   

 // print_r($data); die();
  $connection = mysqli_connect('localhost','root','','restoran');
  $tables = array(
    "DishesInOrder",
    "DishesInCategory",
    "IngredientsInADish",
    "Ingredients",
    "Supply",
    "Warehouse",
    "Order",
    "Dishes",
    "Employees",
    "Categories"
);
// foreach($tables as $table){
//   $result = mysqli_query($connection,"Delete from ".$table." where 1");
 
// }
foreach($tables as $table){
  $result = mysqli_query($connection,"DROP TABLE ".$table);
 
}
  $filename="../backupFiles/".$data["nameFile"].".sql";
  
  $handle = fopen($filename,"r+");
  var_dump( $handle);
  $contents = fread($handle,filesize($filename));
  $sql = explode(';',$contents);  
  //print_r($sql);
  foreach($sql as $query){
    $result = mysqli_query($connection,$query.";");
  }
    
  fclose($handle);
}