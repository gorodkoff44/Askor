   M S B A M L   `   `   `  ����M  IСтраховая, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:СтраховаяСтраховая  5      "    Страховая.SDogovora   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Страховая     5        N� Title$  	SDogovora��5	      .��5      � .+�5   
   � ��5      �� 5       �� ImageSource$ Resources/bg.png��6   6>    J� Effect 5      -  'System.Windows.Media.Effects.BlurEffect  5         Radius$ 25Q�6   5      �� 5   
   .+�5      � .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DGridClient��5         AutoGenerateColumns .     
IsReadOnly . $��0,0,0,60q�6^      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6P   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6:   �� *F+6P     5      $ Имя��6)   $	 * 6L   
 66   �� *I+6L     5      $ Отчество��6)   $	 * 6Q   
 6;   �� *O+6Q     5      $ Дата рождения��6-   $	 * 6t   
 6D   �� *DR+ �� StringFormat$ 
dd.MM.yyyy��6t     5      $ Авто��6-   $	 * 6U   
 6;   �� *Model+6U     5      $ Госномер��6-   $	 * 6Z   
 6?   �� *Gosnum+6Z   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
	 auto 61      CellTemplate 5       �� 5!      .R�5"   "   ��  ��Name$
 edit��6A   -   5        $ ��Редактировать��5"   )   6O   5#      5%      5'      5)      � 5*      .+�5+      �� -   5        $	 del��5+      $��Удалить��68   $��18(�6J   $��Right=�6X   
����������	#55000000���	#33ffffff6�   �� 5,      -   5        $ Refresh��5,      $��Обновить��6@   $��18(�6S   $��Right=�6a   
����������	#55000000���	#33ffffff6�   5-      5/      50      51      