   M S B A M L   `   `   `  ����J  FProjetAPIWS2023, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProjetAPIWS2023ProjetAPIWS2023  5   	   O,clr-namespace:ProjetAPIWS2023.MVVM.ViewModelProjetAPIWS2023.MVVM.ViewModel  5   	        ProjetAPIWS2023.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ProjetAPIWS2023     5   	   B	viewModel,clr-namespace:ProjetAPIWS2023.MVVM.ViewModel     5   	   $	��600��5	   	   $	��920��6     � WindowStyle$
  None=�5
   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      2  ,ProjetAPIWS2023.MVVM.ViewModel.MainViewModel  5   
   .��5      �� ���#111111 �� CornerRadius$ 20��5       � Cursor$
 Hand��6   ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   5      �� 5      5       � RowDefinitions 5!      �� 5"      $��75 �6    5$      �� 5%      5'      �� 5(      $��55 �6    5*      .+�5-      �� $��COVID HELP 🆘��6   $��Center=�5.      $
��Left=�5/      $��22(�50      
�������$��20, 0, 0, 0q�52      $
��Bold"�53      �� 56      $��1��6   ���#252525.+�5:      	� $��🏚️ Accueil��6   $��50��5;      
�������$��18(�5=         MenuButtonTheme#��[  5>      	 d� 	IsChecked$
	 TrueY�5?      ��5@      �� *HomeViewCommand+	� 5C      $��🗺️ Carte��6   $��50��5D      
�������$��18(�5F      #��[  5G      ��5H      �� *MapViewCommand+	� 5K      $��🏥 Les Centres��6   $��50��5L      
�������$��18(�5N      #��[  5O      ��5P      �� *ListCentreViewCommand+5S      �� 5U      $(��"@2M_DEV - All Right Reserved ©️��6   $��2��5V      $��2��5W      
�������$��Right=�5Y      $��Center=�5Z      $��12q�5[      	� 5_      $��
❓ Nous ?��6   $��50��5`      
�������$��18(�5b      #��[  5c      $��2��5d      �� 5h      $��1��6   $��1��5i      $��10q�5j      ��5k      �� *CurrentView+5n      � 5p      $��1��6    5r      �� 5s      5u      �� 5v      5x      .+�5{      �� $	��250��6   $��40��5|      $��Center=�5}      $
��Left=�5~      $��5q�5      $��0��5�        ModernTextbox#��[ 5�      �� 5�      -   5        
 ��Name$
 closeAppBtn��5�      $��Right=�5�      $��Center=�5�      $��15q�5�      $��1��5�      $	��❌��5�      
���  ��$��18(�5�      $
��Bold"�5�      $
 Hand��5�      
������ 5�      5�      5�      5�      5�      