   M S B A M L   `   `   `  ����D  @Nyam-Nyam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Nyam_Nyam.PagesNyam_Nyam.Pages  5      !    Nyam_Nyam.Pages.PAddNewDish   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Nyam_Nyam.Pages     5        N� Title$  PAddNewDish��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   .+�5   
   � .+�5      �� $��Disabled=�6   $
��Auto=�5      .��5      �� $��10q�6   .+�5      �� $
��Dish��6    $��20(�5       $��	Underline{�5       �� 5      $
��Name��6    $��16(�5       �� 5      $��16(�5       �� 	MaxLength$ 50��5       ��5      �� *Name+5       �� 5!      $��Description��6    $��16(�5"       �� 5#      $��16(�5$      ��5#      �� *Description+5$      �� 5%      $��Source recipe link��6    $��16(�5&       �� 5'      $��16(�5(      ��5'      �� *SourceRecipeLink+5(      �� 5)      $��Base servings��6    $��16(�5*       �� 5+      -   5        $��16(�5,      $ 2��5-      ��5+      �� *BaseServings+5.      �� 5/      $��Final price��6    $��16(�50       �� 51      -   5        $��16(�52      ��51      �� *
FinalPrice+53      �� 54      $��Category��6    $��16(�55       �� 56      -   5         ��Name$ 
CBCategory��56       �� DisplayMemberPath$
 Name��57      $��16(�59       �� SelectedItem 58      �� *
Category+59      �� 5:      $	��250��5;      $	��400��5<       �� BitmapScalingMode$
 Fant=�5=      $
��Fill=�5>      ��5:      �� *Photo+5>      �� 5?      -   5         ��Name$ BPhoto��5?      $��	Add photo��5A      5B      5C      5D      � 5F   
   $��1��6    5G      �� 5H      $
��auto �6    �� 5I      .+�5K      �� $��10q�6   .+�5L      �� $��Steps recipe��6   $��20(�5M      $��	Underline{�5N      �� 5O      $��Process description��6   $��16(�5P      �� 5Q      -   5        	 ��Name$	 TBStep��5Q      $��16(�5R      �� 5S      $��Time in minutes��6   $��16(�5T      �� 5U      -   5        $	 TBTime��5U      $��16(�5V      �� 5W      -   5        $ BAddStep��5W      $��Add step��5X      5Y      5Z      &   System.Windows.Controls.DataGrid  5[      -   5        
  Name$
 DGSteps��5_         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5[         
IsReadOnly .    AutoGenerateColumns .     CanUserAddRows .  $��1��5`      $   HorizontalScrollBarVisibility$ Disabled=�5b      "   VerticalScrollBarVisibility$
 Auto=�5c         Columns 5d      0  *System.Windows.Controls.DataGridTextColumn  5e      ,  &System.Windows.Controls.DataGridColumn   Header$ Process description��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5f   )   �� *ProcessDescription+   ElementStyle 5g      �� 5h      .�5i   "   ��  �� Property � �� �� Value$
 Wrap=�5j   )   �� 5k   "    �@��TextAlignment$ Justify=�5l   )   5m      5o        5p      $
 Time��6)    5q   )   �� *Time+5s      5t      � 5u   
   $��2��6    5v      �� 5w      $
��auto �6    �� 5x      .+�5z      �� $��10q�6   .+�5{      �� $��Ingredients��6   $��20(�5|      $��	Underline{�5}      �� 5~      $$��Selected ingredients for steps��6   $��16(�5      �� 5�      -	   5        $ CBIngredient��5�      $
 Name��5�      $��16(�5�      �� 5�      $��Quantity��6   $��16(�5�      �� 5�      -
   5        $	 
TBQuantity��5�      $��16(�5�      �� 5�      -   5        $ BAddIngredient��5�      $��Add ingredient��5�      5�      5�        5�      -   5        $
 DGIngredients��5�      $ * 5�       . $��1��5�       .   .   5�        5�      $ Process description��6)    5�   )   �� *Ingredient.Name+  5�      $
 Time��6)    5�   )   �� *Ingredient.PricePerUnit+5�      5�      �� 5�   
   $��1��6   $��3��5�      $��Center=�5�      $��10q�5�      $��Center=�5�      .+�5�      �� -   5        $ BSave��5�      $
��Save��5�      $��2q�5�      $	��300��5�      $��25��5�      �� 5�      -   5        $ BDelete��5�      $��Delete��5�      $��2q�5�      $��25��5�      �� 5�      -   5        $ BCancel��5�      $��Cancel��5�      $��2q�5�      $��25��5�      5�      5�      5�      