   M S B A M L   `   `   `  ����D  @Nyam-Nyam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Nyam_Nyam.PagesNyam_Nyam.Pages  5          Nyam_Nyam.Pages.PDishes   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Nyam_Nyam.Pages     5      -   5          N� Title$  PDishes��5
      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   �� .+�5      �� $��List of Dishes��6   $��28(�5      $��	10,0,0,10q�5      �� 5       �� Orientation$ 
Horizontal=�6   $��Center=�5      .+�5      �� $ 
Horizontal=�6   .+�5      �� $��	Category:��6    $��0,0,5,0q�5       $��18(�5       �� 5      -   5         ��Name$ 
CBCategory��5      $	��150��5       �� DisplayMemberPath$
 Name��5      $��18(�5       5!      5"      �� 5#      $ 
Horizontal=�6   $��10,0,0,0q�5$      .+�5%      �� $��Name:��6    $��0,0,5,0q�5&       $��18(�5'       �� 5(      -   5         ��Name$ TBSurch��5(      $	��150��5)      $��18(�5*       �� 	MaxLength$ 50��5+      5,      5-      �� 5.      $ 
Horizontal=�6   $��10,0,0,0q�5/      .+�50      �� $��Add new Dish:��6    $��0,0,5,0q�51       $��18(�52       �� 53      -   5         ��Name$ 
AddNewdish��53      $��Add new��54      $	��150��56      $��18(�57      58      59      5:      �� 5;   
   -   5         ��Name$ LVDishes��5<      $��Disabled=�5;      $
��auto��5=      $��1��5?      $��1q�5@      $��10q�5A      ��5D      �� 5E      .R�5F      � .+�5G      �� $	��250��5H       $	��400��5I       	 �� BitmapScalingMode$
	 Fant=�5J       
 J� OpacityMask

 �   �$
��Fill=�5L       ��5G       �� *Photo+5L       �� 5M      
������� J� Opacity$	 0.5Q�5N   !   $	��125��5O   !   $	��400��5P   !   $��Bottom=�5Q   !   5R      �� 5S      $	��125��6&   $	��400��5T   &   $��Bottom=�5U   &   $��Center=�5V   &   .+�5W      �� $��Center=�5X   (   $��28(�5Y   (   
�������$
��Wrap=�5[   (    �� TextAlignment$ Center=�5\   (   ��5W   (   �� *Name+5\   (   �� 5]      $��Center=�5^   (   $
��Wrap=�5_   (   $��28(�5`   (   
���������5]   (   �� *
FinalPrice+ �� StringFormat$
 ${0}��5a   (   5b      5c      5d      ��5f      �� 5g      .R�5h      �  � Orientation$ 
Horizontal=�6    5i      5k      5l      5m      