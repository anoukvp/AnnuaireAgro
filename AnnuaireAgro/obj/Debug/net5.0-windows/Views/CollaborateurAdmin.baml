   M S B A M L   `   `   `  ����G  CAnnuaireAgro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AnnuaireAgro.ViewsAnnuaireAgro.Views  5      +    %AnnuaireAgro.Views.CollaborateurAdmin   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      2Views clr-namespace:AnnuaireAgro.Views     5        N� Title$  CollaborateurAdmin��5      .��5      � $��Center=�6   $��Center=�6(    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $��38.963 �6   �� 5      $��61.037 �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        $��lbCollaborateur��5      $��0��5      $��1��6#   $��2��61   $ �� IsSynchronizedWithCurrentItem$
 TrueY�5      $��2��5   <   $��0,0,0,80q�6P   ��6   �� *ListeCollaborateur+��5      �� 5       .R�5!      ��  �� Orientation$ 
Horizontal=�6!   .+�5"      �� ��6$   �� *Nom+6;   �� 5#      $��
 10 0 0 0 q�6<   ��6$   �� *Prenom+6R   5$      5%      5'      &    AnnuaireAgro.Views.ucCollabAdmin  5)   
   $��1��6   $��2��6,   $��0,0,0,10q�6j   $��2��6|    � DataContext 6<   �� *CollaborateurSelected+6|   �� 5,   
   $ 
Horizontal=�6   $��2��6.   $��3��6;   $��Center=�5-      $��0,0,0,0q�62   $	��Top=�6C   .+�5/      �� -   5         ��Name$ 	newCollab��5/      $��Créer��6(   $��10,5,0,0q�6Q   $	��100��6d   ���	#FF246887
�������6�   �� 51      $��Enregistrer��6   $	��100��6K   $��10,5,0,0q�6Z   ���	#FF246887
���������6+   �� *SaveCommand+6�   �� 52      $��	Supprimer��6   $	��100��6K   $��10,5,0,0q�6Z   ���	#FF246887
���������6)   �� *DeleteCommand+6�   53      55      58      