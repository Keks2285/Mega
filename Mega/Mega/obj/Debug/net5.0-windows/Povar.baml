   M S B A M L   `   `   `  ?????  ;Mega, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MegaMega  5   	       
Mega.Povar   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QScottPlot.WPF, Version=4.1.60.0, Culture=neutral, PublicKeyToken=e53b06131e34a3aae aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Mega     5   	   -   5          ? Title$  Окно повара??5   	   $	??450??6   $	??800??6*   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $
??479* ?6   6.   ?? 5      $
??321* ?6   6.   .+?5   
   ?? -   5         ??Name$ IngridientsBtn??5      $*??$Ингридиенты и блюда??6)   $
??Left=?6G   $??	10,10,0,0q?6b   $	??Top=?6u   $	??200??6?    ? Cursor$
 Hand??6?   $??32??6?   ?? 5   
   -   5        $??
Выход??5      $??Right=?6!   $	??Top=?6=   ???	#FFC52B2B$??1??6l   $??75??6|   $??32??6?   $
 Hand??6?   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
OrdersGrid??5   ?   $??0,112,30,10q?6      CanUserAddRows$ False??6(      AutoGenerateColumns$ False??6S      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly$
 True??6J   	   CanUserSort$
	 True??6]   
   Header$
 
Номер??6p   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ??  ?? Path$ TableNumber?6?     5      $
 True??6C   $
	 True??6U   $
 Стоимость??6h    6%   ?? $
 Cost?6}     5      $
 True??6H   $
	 True??6Z   $
 Дата-Время??6m    6%   ?? $ 	DateOrder?6?     5      $
	 True??6F   $
 Статус??6Y    6%   ?? $ Status?6k   5        5   
   -   5        $ DishesDg??5   (   $??65,112,10,0q?6   $ False??6:   $ False??6V   $??1??6m    5        5      $
 True??6D   $
	 True??6W   $
 
Блюда??6j    6%   ?? *
NameDishes+6j   5      5      5       