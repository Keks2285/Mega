   M S B A M L   `   `   `  ?????  ;Mega, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MegaMega  5   	       Mega.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QScottPlot.WPF, Version=4.1.60.0, Culture=neutral, PublicKeyToken=e53b06131e34a3aae aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   localclr-namespace:Mega  5   	   -   5          ? WindowState$  	Maximized=?5       ? Title$ 
MainWindow??5	   	   $	??450??6   $	??800??6)   .??5
      ?  ? ColumnDefinitions 5   
   ?? 5      $
??237* ?6   6.   ?? 5      $
??177* ?6   6.   ?? 5      $
??386* ?6   6.   .+?5   
   ?? -   5         ??Name$ Authorization??5      $1??+Авторизация сотрудника??6(   $??Right=?6J   $	??Top=?6f   $??32??6?   $	??196??6?   $??2??6?   ?? 5   
   $??Наше меню??6   $
??Left=?6$   $??158,102,0,0q?6?   $	??Top=?6T   $??2??6l    J? RenderTransformOrigin$ 0.5,0.5&?6|   $	??150??6?   $??24??6?   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$
 Menu??5   -      CanUserDeleteRows$ False??6   $??34,140,10,11q?6;      CanUserAddRows$ False??6Q      AutoGenerateColumns$ False??6h   $??2??6?   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   
IsReadOnly$

 True??6%      CanUserSort$
 True??6\      Header$ Название??6o   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   ??  ?? Path$ 
NameDishes?6?     5      $

 True??6%   $
 True??6U   $ Стоиость??6h    67   ?? $
 Cost?6|     5      $

 True??6%   $
 True??6W   $ Вес в г.??6j    67   ?? $ Weight?6~   5      ?? 5   
    ?? CornerRadius$ 15??6   ???	#FFABADB3
???????$	??Top=?6O   $??1q?6g   $??37??6|   $??
22,10,55,0q?6?   ._?5      ?? -   5         ??Name$ NameDish??5   $   $??14(?6   $??0q?66   
??????  %  !MaterialDesignFloatingHintTextBox#??[  6f   $??Center=?6?   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Название??6?   $??9,0,9,0q?6?   $??40??6?   5      ?? 5   
   -   5        $ Search??5      $??Поиск в меню??6!   $
??Left=?68   $??	13,12,0,0q?6S   $	??Top=?6f   $??1??6?   $??32??6?   $??76??6?   ?? 5    
   -   5        $ AddInOreder??5       $$??Добавить в заказ??6&   $??Center=?6A   $??	0,217,0,0q?6^   $	??Top=?6q   $??1??6?   $??32??6?   $	??176??6?   ?? 5!   
   -   5         ??Name$ 	OrderList??5!   *   
???????$??
0,103,4,10q?6=    ?? View 5"      ?? 5#      .P?5$      ??  ?? DisplayMemberBinding 6%   ?? $ 
NameDishes?.??6V   
Блюдо6]   ?? 5%       6%   ?? $
 Cost?.??6Q   Стоимость6\   5&      5(      ?? 5)   
   -   5        $ 
CeateOrder??5)      $!??Оформить заказ??6%   $
??Left=?6>   $??113,140,0,0q?6Y   $	??Top=?6n   $??1??6?   $??32??6?   $??0??6?   ?? 5*   
   -	   5         ??Name$ 
TotalPrice??5*   .   $*??$Итоговая стоимость:??6   $
??Left=?6B   $??	1,177,0,0q?6]   $	??Top=?6p   $	??166??6?   $??24??6?   $??1??6?   5+      5,      