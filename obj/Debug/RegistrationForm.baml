   M S B A M L   `   `   `  ����C  ?OptiChat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:OptiChatOptiChat  5   	       OptiChat.RegistrationForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:OptiChat     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5          � Title$  RegistrationForm��5   	      MaterialDesignBody#���   5
   	   ���	#FFFAFAFA$��Medium"�5   	   $��14(�5   	    � AllowsTransparency .  � ShowInTaskbar .  � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ CanResizeWithGrip=�6.    � WindowStyle$
 None=�5   	   $	��320��6   $	��455��6+   $	��450��5   	   $	��680��6   $	��320��6)   $	��450��65   ��5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      ��  �� Padding$ 10q�6   ���	#FF232323._�5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5!      �� -   5         ��Name$ GoBack��5!      $
��Left=�6%   $��6��6@   $��0q�5"   @   
������ $��Normal"�5$   .   $��0,23,0,0q�6B   ��5#      0  *MaterialDesignThemes.Wpf.PackIconExtension  	   Kind$	 ArrowLeftThick=�5$   B   �� 5&      $��Normal"�6   $��Register On Optichat��6,   $��Heebo ExtraBold)�5'      $��Center=�5(      $��Center=�65   
�������$��25(�5)   *   $��0,25,0,0q�68   $��0��6J   �� 5+      -   5        
 ��Name$
 FirstNameBox��5+      $��1��6,   $��
First Name��69   $��15(�6K   $��SemiBold"�5,      $��Stretch=�6,   $��30��6J   $��Heebo Medium)�5-      $��Center=�5.      
������� �� TextAlignment$ Center=�6C   $��0,25,0,0q�5/      $��1q�6(   ���	#FF3068FF6<   �� 51      -   5        $
 LastNameBox��51      $��2��6+   $��	Last Name��68   $��15(�6I   $��SemiBold"�52      $��Stretch=�6,   $��30��6J   $��Heebo Medium)�6V   $��Center=�53      
�������$ Center=�6C   $��0,25,0,0q�55      $��1q�6(   ���	#FF3068FF6<   �� 57      -   5        $
 UsernameBox��57      $��3��6+   $��Username��68   $��15(�6H   $��SemiBold"�58      $��Stretch=�6,   $��30��6J   $��Heebo Medium)�6V   $��Center=�59      
�������$ Center=�6C   $��0,25,0,0q�5;      $��1q�6(   ���	#FF3068FF6<   �� 5>      -   5        $
 EmailAddressBox��5>      $��4��6/   $��Email Address��6<   $��15(�6Q   $��SemiBold"�5?      $��Stretch=�6,   $��30��6J   $��Heebo Medium)�6V   $��Center=�5@      
�������$ Center=�6C   $��0,25,0,0q�5B      $��1q�6(   ���	#FF3068FF6<   �� 5F      -   5        $ 	EyeButton��5K      
������ $��Right=�5F   \   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 50��5G      $��Right=�6D   $��0q�5H      $��0,25,0,0q�5I   >   $��5��5J      $��25��6#   $��48��6/   $��0��6:    K� ZIndex$ 4��5K   )   ��5F        $		 Eye=�5K   )   �� 5M      -   5        $
 PasswordBoxRevealerBox��5M      $��5��66   $��Password��6C   $��15(�6S   $��SemiBold"�5N      $��Stretch=�6,   $��30��6J   $��Heebo Medium)�6V   $��Center=�5O      
�������$ Center=�6C   $��2��6[   $��0,25,0,0q�5P      $��1q�6(   ���	#FF3068FF6<   G� 5R      -	   5         G�Name$ PasswordBox��5R      $��5��6/   $��15(�6<   $��SemiBold"�6J   $��Stretch=�5S      $��Center=�68   $��Center=�5T      
�������$��30��6G   $��Heebo Medium)�6S   $��Center=�5U      $��0,25,0,0q�6<   $��1q�5V      ���	#FF3068FF$ 2��6F   5W      �� 5Y      -
   5        $ RegisterButton��5[      $��Register��5Y      $��Center=�6)   $��Center=�5Z      $��Center=�5[   .   ���	#FF506FFF$	��100��5\      $��30��6"   $��6��6/   $��0,25,0,0q�6<     MaterialDesignRaisedButton#��[ 5]      $��Heebo Medium)�5^      $ 15��5_      ���	#FF3068FF$��Center=�5`      $��15(�61   5e      5f      5g      