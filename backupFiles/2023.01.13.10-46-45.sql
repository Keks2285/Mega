
CREATE TABLE `Categories` (
  `ID_Categories` int NOT NULL AUTO_INCREMENT,
  `NameCategories` varchar(50) NOT NULL,
  PRIMARY KEY (`ID_Categories`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
INSERT INTO Categories VALUES("1","[value-2]");
INSERT INTO Categories VALUES("2","564894894");
INSERT INTO Categories VALUES("3","ikfdgbjigfjdhiub");

CREATE TABLE `Employees` (
  `ID_Employees` int NOT NULL AUTO_INCREMENT,
  `Surename` varchar(50) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `PasportNumber` int NOT NULL,
  `PasportSiries` int NOT NULL,
  `Position` varchar(40) NOT NULL,
  `Salary` int NOT NULL,
  `Email` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Snils` varchar(11) NOT NULL,
  PRIMARY KEY (`ID_Employees`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
INSERT INTO Employees VALUES("1","нпанга","рпкер","рврепр","111111","2222","Администратор","75000","example@gmail.com","aa5b9f5dbe9ad5f96a4235e85ed897de","56454456");
INSERT INTO Employees VALUES("2","твоаров","ыогмрг","гавпир","12365","1542","Кадровый менеджер","15622","example1@gmail.com","aa5b9f5dbe9ad5f96a4235e85ed897de","566146545");
INSERT INTO Employees VALUES("6","пупуке","гфваргыуа","ваыуав","1111","1111","Повар","89748","fufhgufh@vfh.com","aa5b9f5dbe9ad5f96a4235e85ed897de","45484584645");
INSERT INTO Employees VALUES("8","ацаца","ауыцацуы","ацуаува","4848","8985","сывапкцуа","4562","example2@gmail.com","9c9d1e7110a8c27d9aec8530633e6776","21654549848");

CREATE TABLE `Dishes` (
  `ID_Dishes` int NOT NULL AUTO_INCREMENT,
  `NameDishes` varchar(20) NOT NULL,
  `Cost` int NOT NULL,
  `Weight` varchar(10) NOT NULL,
  PRIMARY KEY (`ID_Dishes`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
INSERT INTO Dishes VALUES("1","Гамбургер","70","150");
INSERT INTO Dishes VALUES("2","Чизбургер","49","120");
INSERT INTO Dishes VALUES("3","Картошка фри","79","140");
INSERT INTO Dishes VALUES("4","Кола 0.5","85","500");
INSERT INTO Dishes VALUES("5","Кола 0.8","105","800");
INSERT INTO Dishes VALUES("6","Чикенбургер","70","140");
INSERT INTO Dishes VALUES("7","Двойной Чикенбургер","140","250");

CREATE TABLE `Order` (
  `ID_Order` int NOT NULL AUTO_INCREMENT,
  `TableNumber` int NOT NULL,
  `DateOrder` varchar(255) NOT NULL,
  `Cost` int NOT NULL,
  `Status` varchar(10) NOT NULL,
  PRIMARY KEY (`ID_Order`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
INSERT INTO Order VALUES("10","58117","13.01.2023 8:55:18","213","Оформлен");
INSERT INTO Order VALUES("11","2274","13.01.2023 10:08:35","234","Оформлен");
INSERT INTO Order VALUES("12","37603","13.01.2023 10:08:48","234","Оформлен");

CREATE TABLE `Ingredients` (
  `ID_Ingredients` int NOT NULL AUTO_INCREMENT,
  `NameIngredients` varchar(255) NOT NULL,
  PRIMARY KEY (`ID_Ingredients`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
INSERT INTO Ingredients VALUES("1","Огурчик");
INSERT INTO Ingredients VALUES("2","Помидор");
INSERT INTO Ingredients VALUES("3","Котлета куриная");
INSERT INTO Ingredients VALUES("4","Котлета говяжая");

CREATE TABLE `DishesInCategory` (
  `ID_DishesInCategory` int NOT NULL AUTO_INCREMENT,
  `Categories_ID` int NOT NULL,
  `Dishes_ID` int NOT NULL,
  PRIMARY KEY (`ID_DishesInCategory`),
  KEY `DishesInCategory_fk0` (`Categories_ID`),
  KEY `DishesInCategory_fk1` (`Dishes_ID`),
  CONSTRAINT `DishesInCategory_fk0` FOREIGN KEY (`Categories_ID`) REFERENCES `Categories` (`ID_Categories`) ON DELETE CASCADE,
  CONSTRAINT `DishesInCategory_fk1` FOREIGN KEY (`Dishes_ID`) REFERENCES `Dishes` (`ID_Dishes`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
INSERT INTO DishesInCategory VALUES("1","1","1");
INSERT INTO DishesInCategory VALUES("3","2","1");

CREATE TABLE `IngredientsInADish` (
  `ID_IngredientsInDish` int NOT NULL AUTO_INCREMENT,
  `Amount` int NOT NULL,
  `Dishes_ID` int NOT NULL,
  `Ingredients_ID` int NOT NULL,
  PRIMARY KEY (`ID_IngredientsInDish`),
  KEY `IngredientsInADish_fk0` (`Dishes_ID`),
  KEY `IngredientsInADish_fk1` (`Ingredients_ID`),
  CONSTRAINT `IngredientsInADish_fk0` FOREIGN KEY (`Dishes_ID`) REFERENCES `Dishes` (`ID_Dishes`) ON DELETE CASCADE,
  CONSTRAINT `IngredientsInADish_fk1` FOREIGN KEY (`Ingredients_ID`) REFERENCES `Ingredients` (`ID_Ingredients`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
INSERT INTO IngredientsInADish VALUES("1","123","1","1");

CREATE TABLE `Warehouse` (
  `ID_Warehouse` int NOT NULL AUTO_INCREMENT,
  `Cells` int NOT NULL,
  `Amount` int NOT NULL,
  `Ingredients_ID` int NOT NULL,
  PRIMARY KEY (`ID_Warehouse`),
  KEY `Warehouse_fk0` (`Ingredients_ID`),
  CONSTRAINT `Warehouse_fk0` FOREIGN KEY (`Ingredients_ID`) REFERENCES `Ingredients` (`ID_Ingredients`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
INSERT INTO Warehouse VALUES("1","150","1501","1");

CREATE TABLE `Supply` (
  `ID_Supply` int NOT NULL AUTO_INCREMENT,
  `Provider` varchar(50) NOT NULL,
  `DateSupply` varchar(255) NOT NULL,
  `CostSupply` int NOT NULL,
  `Warehouse_ID` int NOT NULL,
  `Ingredient_ID` int NOT NULL,
  PRIMARY KEY (`ID_Supply`),
  KEY `Supply_fk1` (`Warehouse_ID`),
  KEY `Ingredient_ID` (`Ingredient_ID`),
  CONSTRAINT `Supply_fk1` FOREIGN KEY (`Warehouse_ID`) REFERENCES `Warehouse` (`ID_Warehouse`) ON DELETE CASCADE,
  CONSTRAINT `supply_ibfk_1` FOREIGN KEY (`Ingredient_ID`) REFERENCES `Ingredients` (`ID_Ingredients`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
INSERT INTO Supply VALUES("1","Мясокобинат","2022-11-15","45894","1","1");

CREATE TABLE `DishesInOrder` (
  `ID_DishesInOrder` int NOT NULL AUTO_INCREMENT,
  `Dishes_ID` int NOT NULL,
  `Order_ID` int NOT NULL,
  PRIMARY KEY (`ID_DishesInOrder`),
  KEY `oder_fk` (`Order_ID`),
  KEY `dises_fk` (`Dishes_ID`),
  CONSTRAINT `dises_fk` FOREIGN KEY (`Dishes_ID`) REFERENCES `Dishes` (`ID_Dishes`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `oder_fk` FOREIGN KEY (`Order_ID`) REFERENCES `Order` (`ID_Order`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
INSERT INTO DishesInOrder VALUES("5","2","10");
INSERT INTO DishesInOrder VALUES("6","3","10");
INSERT INTO DishesInOrder VALUES("7","4","10");
INSERT INTO DishesInOrder VALUES("8","1","11");
INSERT INTO DishesInOrder VALUES("9","3","11");
INSERT INTO DishesInOrder VALUES("10","4","11");
INSERT INTO DishesInOrder VALUES("11","1","12");
INSERT INTO DishesInOrder VALUES("12","3","12");
INSERT INTO DishesInOrder VALUES("13","4","12");
