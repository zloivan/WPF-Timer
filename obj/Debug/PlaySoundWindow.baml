   M S B A M L   `   `   `  ����  Visual Timer    WPFTimer.PlaySoundWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Alarm!��5   	   $	��300��6   $	��300��6%    � 
ResizeMode$ NoResize=�61    � Icon$  Icons/1449733481_timer.ico��6G    � WindowStyle$ 
ToolWindow=�6i    � WindowStartupLocation$ CenterOwner=�6�   .��5      �  � 	Resources 5   
    �� 
TargetType �� Property �� Value	 �� Triggers
 :� RoutedEvent �� Source��%�   '��       �� 5      " ��6   .�5      ��  � ��
 �����6/   	 5	      :� 5
      $
 PreviewMouseDown��6#   .[�5      �� $. (Resources/KeypressStandard_converted.wav?�6,   5      5      5       � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ btnStop��5      $��1��6#   $��Stretch=�63   $��2��6R   $��Stretch=�6_    �� 	IsDefault . .��5      (� .��5      �� Stop5       5!      5"      �� 5#   
   $��3��6   $&�� Icons\1449733439_finish_flag.ico��5$   J   5%      5&      5'      