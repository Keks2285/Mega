   M S B A M L   `   `   `  ?????  ;Mega, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MegaMega  5   	   #    Mega.WarehousesSuppliesWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QScottPlot.WPF, Version=4.1.60.0, Culture=neutral, PublicKeyToken=e53b06131e34a3aae aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Mega     5   	   _ [MaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     ? WindowState$  	Maximized=?5       ? Title$ WarehousesSuppliesWindow??5	   	   $	??450??6*   $	??800??67   .??5
      ?  ? ColumnDefinitions 5   
   ?? 5      6!   ?? 5      6!   ?? 5      6!   ?? 5      6!    ? RowDefinitions 5   
   ?? 5      $	??37* ?6   6+   ?? 5      $	??25* ?6   6+   .+?5   
   ??  ?? CornerRadius$ 15??6   ???	#FFABADB3
???????$	??Top=?6Q   $??1q?6i   $??42??6~   $??2??6?   $??1??6?   $??
10,10,10,0q?6?   $??2??6?   ._?5      ?? -   5         ??Name$ Adres??5   T   $??14(?6   $??0q?6%   
??????  %  !MaterialDesignFloatingHintTextBox#??[  6c   $??Center=?6?   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Адрес??6?   $??9,0,9,0q?6?   $??40??6?   5      ?? 5   
   $ 15??6   ???	#FFABADB3
???????$	??Top=?6Q   $??1q?6i   $??42??6~   $??
10,57,65,0q?6?   $??2??6?   $??1??6?   ._?5      ?? -   5        $ CellsTb??5   T   $??14(?6   $??0q?6%   
?????? #??[  6e   $??Center=?6?   $ Ячейки??6?   $??9,0,9,0q?6?   $??40??6?   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ WarehousesList??5         CanUserSortColumns$
 True??6+   $	   HorizontalScrollBarVisibility$
	 Auto=?6F   "
   VerticalScrollBarVisibility$

 Auto=?6k      AutoGenerateColumns$ False??6?      CanUserDeleteRows$
 True??6?      CanUserAddRows$ False??6?      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6?   $??10,48,10,17q?6?   $??2??61  $??2??6A     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   CanUserSort$
 True??6@      Header$ 
Адрес??6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ?? *Adres+6S     5      $
 True??6@   $ Ячейки??6S    6%   ?? *Cells+6S     5       $
 True??6A   $ Количество??6T    6%   ?? *Amount+6T   5"      ?? 5#   
   $ 15??6   ???	#FFABADB3
???????$	??Top=?6Q   $??1q?6i   $??42??6~   $??
10,57,90,0q?6?   $??3??6?   $??1??6?   ._?5$      ?? -   5        $ 	AmmountTb??5$   T   $??14(?6   $??0q?6%   
?????? #??[  6g   $??Center=?6?   $ Количество??6?   $??9,0,9,0q?6?   $??40??6?   5%      ?? 5&   
   -   5         ??Name$ CreateWareHousebtn??5&   ?   $!??Добавить склад??6   $
??Left=?6*   $??
40,127,0,0q?6E   $	??Top=?6Y   $??38??6q   $	??150??6}    ? Cursor$
 Hand??6?   $??3??6?   $??1??6?     5'   
   -   5        $ Supplies??5'      $
 True??6%   $
	 Auto=?6@   $

 Auto=?6e   $ False??6?   $
 True??6?   $ False??6?   $ * 6?   $??0,109,10,10q?6?   $??2??6%  $??2??66   5(        5)      $
 True??6C   $ Поставщик??6V    6%   ?? *
Provider+6V     5*      $
 True??6E   $ Дата??6X    6%   ?? *
DateSupply+6X     5+      $
 True??6E   $ Стоимость??6X    6%   ?? *
CostSupply+6X   5-      ?? 5.   
   $??Поставки??6   $
??Left=?6#   $??
100,60,0,0q?6>   $	??Top=?6R   $??24??6j   $??59??6v   ?? 5/   
   $??Склады??6   $
??Left=?6!   $??	200,9,0,0q?6<   $	??Top=?6O   $??1??6g   $??71??6w   $??24??6?   ?? 50   
   -   5        $
 Back??50      $??
Назад??6   ???	#FFC52B2B$
??Left=?6F   $	??Top=?6b   $??84??6z   $
 Hand??6?   $??32??6?   52      53      