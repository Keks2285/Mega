   M S B A M L   `   `   `  ?????  ;Mega, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MegaMega  5   	       Mega.KadrWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QScottPlot.WPF, Version=4.1.60.0, Culture=neutral, PublicKeyToken=e53b06131e34a3aae aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Mega     5   	     ? Title$  
KadrWindow??5   	   $	??450??6   $	??800??6)   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $	??39* ?6   6-   ?? 5      $
??125* ?6   6.   ?? 5      $
??111* ?6   6.   ?? 5      $	??75* ?6   6-   ?? 5      $	??50* ?6   6-    ? RowDefinitions 5   
   ?? 5      $	??10* ?6   6+   ?? 5      $
??327* ?6   6,   ?? 5      $
??113* ?6   6,   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ EmployeesGrid??5   ?      CanUserSortColumns$
 True??6   $   HorizontalScrollBarVisibility$
 Auto=?6.   "   VerticalScrollBarVisibility$
 Auto=?6S      AutoGenerateColumns$ False??6v      CanUserDeleteRows$
 True??6?   	   CanUserAddRows$	 False??6?   
   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 * 6?   $??	10,0,10,0q?6?   $??1??6?   $??3??6     RowStyle 5      ?? 5       ?? 
TargetType)  #System.Windows.Controls.DataGridRow"  6    ?? Triggers 5      ?? 5       ?? Binding 6&   ?? *	ID_Status+ ?? Value 26D   .a?5      ??  ?? Property ? ?? ?? Value ?	#FFE666666;   5      5         Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   CanUserSort$
 True??6H      Header$ Фамилия??6[   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ??  ?? Path$ LastName?6n     5#      $
 True??6C   $ Имя??6V    6%   ?? $
 Name?6e     5$      $
 True??6H   $ Отчество??6[    6%   ?? $ Surename?6o     5%      $
 True??6E   $ 
Почта??6X    6%   ?? $ Email?6i     5&      $
 True??6H   $ Должность??6[    6%   ?? $ Position?6p     5'      $
 True??6M   $ 
Номер??6`    6%   ?? $ PasportNumber?6q     5(      $
 True??6M   $ 
Серия??6`    6%   ?? $ PasportSiries?6q     5)      $
 True??6E   $ 
СНИЛС??6X    6%   ?? $ Snils?6i     5*      $
 True??6F   $ 
Оклад??6Y    6%   ?? $ Salary?6j   5.      ?? 5/   
   -   5         ??Name$ Export??5/   !   $??1??6   $??Экспорт в csv??61   $
??Left=?6I   $??	10,10,0,0q?6d   $??2??6w   $	??Top=?6?    ? Cursor$
 Hand??6?   $??32??6?   $	??120??6?   ?? 50   
   -   5        $ Create??50   !   $??1??6   $#??Добавить нового??61   $
??Left=?6K   $??	10,47,0,0q?6f   $??2??6y   $	??Top=?6?   $
 Hand??6?   $??32??6?   $	??146??6?     ScottPlot.WpfPlot  51   
   -   5          Name$ EmployersStatistic??51      $??2??6.   $??
169,5,5,10q?6?   $??2??6S   $??3??6b   53      54      