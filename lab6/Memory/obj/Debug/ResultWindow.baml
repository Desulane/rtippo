   M S B A M L   `   `   `  ����
  Memory    Memory.ResultWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$#  Результаты игры��5   	   $	��720��6!   $
��1280��6.    � WindowState$ 	Maximized=�5   	    � WindowStyle$
 None=�5   	   .��5      �  � RowDefinitions 5   
   �� 5	      $��* �6   �� 5
      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ ResultsDataGrid��5      $��0��6,      AutoGenerateColumns .  $��10q�6U   $��24(�6a   $	��640��6o      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Игрок��6%      FontSize$ 24Q�6L   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 64   �� *Key+6L     5      $ Очки��6%   $ 24Q�6M   	 63   �� *Value+6M   5      �� 5   
   -   5        
 ��Name$
 MainMenuButton��5      $��1��6)   $ ��В главное меню��66   $��10q�5      $��10q�6   $��24(�6*   $	��200��68   $��80��6D   5      5      