   M S B A M L   `   `   `  ����G  CAnnuaireAgro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AnnuaireAgro.ViewsAnnuaireAgro.Views  5          AnnuaireAgro.Views.Site   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      2Views clr-namespace:AnnuaireAgro.Views     5        N� Title$
  Site��5      .��5	      � ���	#FF040423$	��378��6"   $	��500��6/    � RowDefinitions 5
   
   �� 5      $
��auto �6   $��61.96��6*   �� 5      $	��61* �6   �� 5      $	��18* �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��Liste des Sites��6   
�������$��30,18,24,18q�6=    J� RenderTransformOrigin$ 0.5,0.5&�6R   �� 5   
   -   5         ��Name$ ListSite��5       �� DisplayMemberPath$ Ville��6l   $��1��6�   $��
30,37,15,2q�6�   ���	#FFA5DCD5��6$   �� *
ListeSites+ �� UpdateSourceTrigger$ PropertyChanged=�6�      AnnuaireAgro.Views.ucSite  5   
   $��1��6   $��2��6$   $��10,10,12,26q�6Y    � DataContext 64   �� *SiteSelected+6Y   �� 5   
    �� Orientation$ 
Horizontal=�6   $��2��6.   $��2��6;   $
��Left=�5      $��	10,10,0,0q�60   $	��Top=�6C   $��25��6[   $	��330��6g   .+�5       �� -   5        	 ��Name$		 new��5       $��Créer��6"   $	��100��63   $��10,5,0,0q�6B   ���	#FF246887
�������6~   �� 5"      $��Modifier��6   $	��100��6H   $��10,5,0,0q�6W   ���	#FF246887
���������6(   �� *SaveCommand+6�   �� 5#      $��	Supprimer��6   $	��100��6K   $��10,5,0,0q�6Z   ���	#FF246887
���������6)   �� *DeleteCommand+6�   5$      5'      5)      