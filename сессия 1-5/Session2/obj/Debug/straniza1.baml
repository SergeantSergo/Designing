   M S B A M L   `   `   `  ����C  ?Session2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Session2Session2  5          Session2.straniza1   5      a ]DevExpress.Xpf.Core.v21.2, Version=21.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:Session2     5        N� Title$  	straniza1��5	      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��150 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	DGridUser��5         AutoGenerateColumns .     
IsReadOnly . $��10,10,10,50q�6T      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$' !Абонентский номер��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6b   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *User_Number+6n     5      $ ФИО��6%   $ * 6L    63   �� *FIO+6X     5      $ Лицевой счет��6%   $ * 6h    6<   �� *Passport_Series_Number+6t     5      $ Услуги��6%   $ * 6Q    66   �� *Email+6]   5      	� 5   
   $��0��6   $��
10,350,0,0q�6&   $��20��6:   $��20��6F   $
��Left=�6Q   6n   	� 5   
   $��0��6   $��250,350,0,0q�6&   $��20��6;   6I   �� 5   
   $��Активные��6   $��0��6#   $��
30,365,0,0q�63   $	��100��6G   $
��Left=�6S   6p   �� 5   
   $��Неактивные��6   $��0��6%   $��270,365,0,0q�65   6L   �� 5!   
   $��1��6   .��5"      �� 	 �� Orientation$	 Vertical=�6   .+�5#      �� 
�������$��0,0,0,10q�6.   6B   �� 5$      
�������$��0,0,0,10q�6.   6B   �� 5%      
�������$��0,0,0,10q�6.   6B   5&      5'      5(      5)      