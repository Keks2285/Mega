   M S B A M L   `   `   `  ?????  ;Mega, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MegaMega  5   	       Mega.Stocker   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QScottPlot.WPF, Version=4.1.60.0, Culture=neutral, PublicKeyToken=e53b06131e34a3aae aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Mega     5   	   _ [MaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     ? WindowState$  	Maximized=?5       ? Title$ Stocker??5	   	   $	??450??6   $	??800??6&   .??5
      ?  ? ColumnDefinitions 5   
   ?? 5      $
??157* ?6   6.   ?? 5      $
??408* ?6   6.   ?? 5      $
??235* ?6   6.   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ IngridientsGrid??5   ?      CanUserSortColumns$
 True??6   $   HorizontalScrollBarVisibility$
 Auto=?6.   "   VerticalScrollBarVisibility$
 Auto=?6S      AutoGenerateColumns$ False??6v      CanUserDeleteRows$
 True??6?   	   CanUserAddRows$	 False??6?   
   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 * 6?   $??22,80,10,106q?6?   $??2??6     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly$
 True??6I      CanUserSort$
 True??6\      Header$ Название??6o   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ?? *NameIngredients+6o   5        5   
   -   5        $ IngridientsInSupplyGrid??5   ?   $
 True??6   $
 Auto=?6/   $
 Auto=?6T   $ False??6w   $
 True??6?   $	 False??6?   $
 * 6?   $??10,56,10,74q?6?    5        5      $
 True??6I   $
 True??6[   $ Название??6n    6%   ?? *NameIngredients+6n   5      ?? 5   
   $??В поставке??6   $
??Left=?6%   $??	36,26,0,0q?6@   $	??Top=?6S   $??24??6k   $??67??6w   ?? 5   
   $+??%Список ингридиентов??6   $??Center=?6.   $	??Top=?6K   $??2??6c   $	??132??6s   $??24??6   ?? 5   
    ?? CornerRadius$ 15??6   ???	#FFABADB3
???????$	??Top=?6Q   $??1q?6i   $??42??6~   $??	0,26,85,0q?6?   $??1??6?   ._?5      ?? -   5         ??Name$ Provider??5   T   $??14(?6   $??0q?6%   
??????  %  !MaterialDesignFloatingHintTextBox#??[  6f   $??Center=?6?   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Поставщик??6?   $??9,0,9,0q?6?   $??40??6?   5       ?? 5!   
   -   5         ??Name$ AddInSupplyBtn??5!      $+??%Добавить Ингридиент??6)   $
??Left=?6G   $??204,182,0,0q?6b   $	??Top=?6w   $??40??6?   $	??201??6?   $??1??6?   ?? 5"   
   $ 15??6   ???	#FFABADB3
???????$	??Top=?6Q   $??1q?6i   $??41??6~   $??5,129,201,0q?6?   $??1??6?   ._?5#      ?? -   5        $ CostTb??5#   T   $??14(?6   $??0q?6%   
?????? #??[  6d   $??Center=?6?   $ Стоимость??6?   $??9,0,9,0q?6?   $??40??6?   5$      (  "System.Windows.Controls.DatePicker  5%   
   -   5          Name$ 
DateSupply??5%      $
??Left=?6)   $??	10,82,0,0q?6D   $	??Top=?6W   $??42??6o   $	??233??6{     MaterialDesignDatePicker#???  6?   $ Дата поставки??6?   $??1??6?     5&   
   -   5        $ WarehousesList??5&      $
 True??6+   $
 Auto=?6F   $
 Auto=?6k   $ False??6?   $
 True??6?   $	 False??6?   $
 * 6?   $??10,232,3,10q?6?   $??1??6   5'        5(      $
 True??6@   $ 
Склад??6S    6%   ?? *Adres+6S   5*      ?? 5+   
   -   5        $+??%Управление складами??5+      $??Right=?6/   $??	0,0,60,42q?6K   $??Bottom=?6^   $	??178??6y   $??35??6?   $??1??6?    ? Cursor$
 Hand??6?   $??2??6?   ?? 5,   
   -	   5        $ CreateSupplyBtn??5,      $%??Создать поставку??6*   $
??Left=?6E   $??
24,184,0,0q?6`   $	??Top=?6t   $??35??6?   $	??164??6?   $
 Hand??6?   $??1??6?   ?? 5.   
   -
   5        $
 Back??5.      $??
Выход??6   ???	#FFC52B2B$??Right=?6F   $??
0,397,10,0q?6b   $??Bottom=?6v   $??2??6?   $??85??6?   $
 Hand??6?   $??32??6?   50      51      