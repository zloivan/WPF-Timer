   M S B A M L   `   `   `  ����  Visual Timer    WPFTimer.HelpWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Help!��5   	   $	��982��6   $	��527��6$    � 
ResizeMode$ NoResize=�60    � WindowStartupLocation$ CenterScreen=�6F    � Icon$ Icons\1449733454_help.ico��6k    � ShowInTaskbar .  .��5      �  � RowDefinitions 5   
   �� 5      $
��128* �6   �� 5      $
��209* �6   �� 5	      $
��166* �6   �� 5
      $
��220* �6   �� 5      $
��231* �6   .+�5   
   �� $��17(�6   $��0��6#   $��Stretch=�60   $��Stretch=�6N   $��5q�6j   $
��Wrap=�6u   $����Hello and welcome to my WPF Timer application. It is made for study purpose and it is not distributable. My name is Ivan Khomichkov and I'm really pleased that u are using my application. Here im gonna note some features that are not obvious.��6�   �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� $��2��6   $
��Left=�6%   $��Stretch=�6@   $��5q�6\   $��1��6g   $#��Resources\FavoritControll.PNG��6t   �� 5      $��14(�6   $
��Left=�6(   $��Stretch=�6C   $��5q�6_   $
��Wrap=�6j   $����This is favorite bar. by clicking to a pluss button, the active timer time will be added to a favorite bar, and when next time you'll need to start timer from that time, all u need to do is to press the time button. This is very handy when timer is set to some special time, for exaple the lengh of 2 tv shows series. It is much more convinient to just press one button instead of seting timer everytime from a start. And when your execute application next time your favorite time collection will be loaded.��6~   $	��388��6�  5      �� 5   
   $��2��6   $ 
Horizontal=�6"   .+�5      �� $��14(�6   $
��Left=�6(   $��Stretch=�6C   $��5q�6_   $
��Wrap=�6j   $����In settings window this panel is responcible for what is going to happen when the timer is reaching its limit. For example you can ask application to turn off your PC, or start your chosen song via WMP.��6~   $	��198��6P  �� 5      $��2��6   $
��Left=�6%   $��Stretch=�6@   $��5q�6\   $��1��6g   $&�� Resources\ChosenRadioBurtton.PNG��6t   5      �� 5   
   $��3��6   $ Vertical=�6"   .+�5      �� $��2��6   $
��Left=�6%   $��Stretch=�6@   $��5q�6\   $��1��6g   $ ��Resources\TurnOffTimer.PNG��6t   �� 5      $��14(�6   $
��Left=�6(   $��Stretch=�6C   $��5,5,0,5q�6_   $
��Wrap=�6p   $����Well this field is kinda self-explenotory. After timer riach its limit the warning window will apear and it will signal that the chosen action is about to happen. And this field sets the time you need this window to be active. ��6�   $	��504��6o  $��83��6{  5      �� 5   
   $��4��6   $ 
Horizontal=�6"   .+�5!      �� $��2��6   $
��Left=�6%   $��Stretch=�6@   $��5,5,5,10q�6\   $��1��6n   $"��Resources\Warning window.PNG��6{   �� 5"      $��14(�6   $
��Left=�6(   $��Stretch=�6C   $��	5,10,0,10q�6_   $
��Wrap=�6r   $����This is a warning window. Beside you can prevent app from starting chosen action, you can start timer once again from 15,30 60 min. ��6�   $	��166��6  5$      5&      5'      