   M S B A M L   `   `   `  ����C  ?sometext, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:sometext.Viewssometext.Views  5   	       sometext.Views.UserPanel   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:sometext.Views     5   	     � Title$  	UserPanel��5   	   $	��450��6   $	��800��6(   .��5	      � 
���   � � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��Center=�6   $��0��60   .+�5      �� -   5        $��
nametxtbox��5   z   $��15(�6T   $��
ExtraLight"�6b   $��30��6�   $��10q�6�   
����  �$��2q�6�   ��6   �� *	NewName+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $��30��68   $	��175��6D   
������$��4q�6i   ��6   �� *AddNameCommand+.��6~   Access6�   5      �� 5   
   $��1��6   $��Center=�6%   .+�5      �� -   5        $��name_listview��5   \   $	��200��6q   $	��175��6~   
���  ��$��3q�6�   ��6   �� *Names+ �� SelectedItem 66   �� *SelectedName+��5      �� 5      .R�5      �� ��6$   �� 5      5       �� 5!      $��Delete��6   
���  ��$	��100��6^   $��10q�6j   ��68   �� *DeleteNameCommand+6j   5$      5&      5'      