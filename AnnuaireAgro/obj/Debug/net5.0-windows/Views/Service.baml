   M S B A M L   `   `   `  ����G  CAnnuaireAgro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AnnuaireAgro.ViewsAnnuaireAgro.Views  5           AnnuaireAgro.Views.Service   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      2Views clr-namespace:AnnuaireAgro.Views     5        N� Title$  Service��5      .��5      � ���	#FF040423$��
0,0,10,-23q�6"   $	��507��66    � ColumnDefinitions 5
   
   �� 5      $��300.142 �6   �� 5      $	��290 �6   �� 5       � RowDefinitions 5   
   �� 5      $	��64* �6   �� 5      $
��410* �6   �� 5      $	��33* �6   .+�5   
   �� $��Liste des Services��6   
�������$��100,14,99,16q�6@   �� 5   
   -   5         ��Name$ ListeServices��5      $��56,19,55,11q�6N   ���	#FFA5DCD5$��1��6z   ��6)   �� *ListeService+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� ��6$   �� *Nom+6;   5      5      5"      "   AnnuaireAgro.Views.ucService  5$   
   $��1��6   $��17,35,16,264q�6R   $��1��6h    � DataContext 6*   �� *ServiceSelected+6h   �� 58   
   $ Vertical=�6   $��1��6,   $��1��69   $��Center=�59      $��0,0,0,40q�62   $��Center=�6D   .+�5:      �� -   5         ��Name$	 new��5:      $��Créer��6"   $	��100��62   $��	10,5,0,10q�6A   ���	#FF246887
�������6~   �� 5;      $��Modifier��6   $	��100��6H   $��	10,5,0,10q�6W   ���	#FF246887
���������6(   �� *SaveCommand+6�   �� 5<      $��	Supprimer��6   $	��100��6K   $��10,5,0,0q�6Z   ���	#FF246887
���������6)   �� *DeleteCommand+6�   5=      5?      5@      