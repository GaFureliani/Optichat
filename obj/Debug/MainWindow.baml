   M S B A M L   `   `   `  ����C  ?OptiChat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:OptiChatOptiChat  5   	       OptiChat.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:OptiChat     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5           MaterialDesignBody#���   5	   	   ���	#FF232323$��Medium"�5   	   $��14(�5   	     � AllowsTransparency  .  � ShowInTaskbar .  � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ CanResizeWithGrip=�6.    � WindowStyle$
 None=�5   	   $	��395��6   $	��455��6+   $	��220��5   	   $	��280��6    � Title$ OptiChat��5   	   $	��425��6   $	��280��6&   ��5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      ��  �� Padding$ 10q�6   ._�5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5       $
��Auto �6#   �� 5!      $
��Auto �6#   .+�5$      �� $��0��6   $��0,0,0,20q�6%   $��Optichat��67   $��	ExtraBold"�5%      $��3��6/   $��Bottom=�5&      $��Center=�63   $��40(�5'      $��Heebo ExtraBold)�6&   ��5(      �� 5)      	 �� EndPoint$	 0.5,0.9&�6*   
 �� 
StartPoint$
 0.5,0&�6=   .��5*      �  � Color$ White��6'    � Offset$ 0Q�65   � 5+      $ White��6'   $ 1Q�65   � 5,      $ 	#FF6C6E6D��6'   $ 0.663Q�69   5-      5/      �� 51      -   5         ��Name$ CloseButton��53      $��0��6+   $��0,2,0,51q�54      $��46��6(   $��22��63   
������ $��0q�55   /    K� ZIndex$ 2��56      $��2��6'   ��51      0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ CloseOutline=�56   '   �� 58      -   5        $ MinimizeButton��5:      $��0,1,2,51q�59   3   $��46��6E   $��22��6P   $��0��5:   .   $��1��6;   $ 2��6K   
������ $��0q�5;   /   ��58        $ WindowMinimize=�5;   /   �� 5=      -   5        $ LoginButton��5?      $��Login��5=      $��Center=�6&   $��Center=�5>      {�.  $��Center=�5?   +   ���	#FF506FFF$��80��5@      $��30��6!   $��4��6.   $��0,5,0,0q�6;     MaterialDesignRaisedButton#��[ 5A      $��3��6J   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5B      ���	#FF3068FF6D   �� 5D      -   5        $ RegisterButton��5G      $��Registration��5D      $��Center=�6-   $��Center=�5E      $��3��5F      $��Center=�6*   ���	#FF506FFF$	��110��5H      $��30��6"   $��5��6/   $��0,10,0,0q�6<   #��[ 5I      $ 15��5J      ���	#FF3068FF6D   �� 5L      -   5         ��Name$ Username��5M   C   $��18(�5L      $��Username��6%   $
��Bold"�65   
������ 
�������$��Center=�5M   U   $��Center=�5N      $��2��69   $��0,0,0,0q�6F    �� TextAlignment$ Center=�5O      
�������$��3��6B   $��1q�5P      5Q      �� 5S      -   5        $ 	EyeButton��5X      
������ $ 50��5T      $��0q�5U      $��2��5V   ?   $��3��5W      $��25��6#   $��1��60   $��48��6A   $ 2��5X   )   ��5S        $	 Eye=�5X   )   �� 5Z      -   5        $ PasswordBoxRevealer��5\   *   $��18(�5Z      $��Password��6%   $
��Bold"�65   
������ $��3��5[   0   $��3��6=   
�������$��Center=�5]      $��1q�6<   $��Center=�5^      $��Stretch=�69   $��Center=�5_      $ Center=�5`       �� 
CaretBrush �	#FF3068FF
�������5a      G� 5d      -	   5         G�Name$ PasswordBox1��5g       G� 	MaxLength$ 24��5d      $��18(�6*   $
��Bold"�68   $��3��5e      $y�Visible=�6/   
������ 
�������$��Center=�5h      $��Center=�5i      $��3��6=   $��30��5j       G� 
CaretBrush �	#FF3068FF$��1q�5k      $��	0,15,0,15q�6/   
�������5o      5p      5q      5r      