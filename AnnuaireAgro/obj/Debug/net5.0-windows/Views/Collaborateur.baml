   M S B A M L   `   `   `  ����G  CAnnuaireAgro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AnnuaireAgro.ViewsAnnuaireAgro.Views  5      &     AnnuaireAgro.Views.Collaborateur   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      2Views clr-namespace:AnnuaireAgro.Views     5        N� Title$  Collaborateur��5      .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   $	��100��6,   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ accueil��5      $��Accueil��6"   ���	#FF246887$��26,05,26,10q�6a   $��30��6v   6�   �� 5   
    �� Orientation$ 
Horizontal=�6   $��0��6.   $��2��6;   $��Center=�5      $��Center=�63   $��	0 5 0 10 q�6N   .+�5      �� $
�� Nom��6   $��Center=�6$   $��5q�6?   
�������6J   �� 5      $	��100��6a   $��Center=�6m   ��6   �� *CollaborateurFiltrer+ �� UpdateSourceTrigger$ PropertyChanged=�6m   �� 5      $�� Site��6   $��Center=�6%   $��5q�6@   
�������6K   �� 5      $	��100��6   $��Center=�6#   �� 5      $��Fonction��6   $��Center=�6(   $��5q�6C   
�������6N   �� 5      $	��100��6   $��Center=�6"   5      �� 5"   
   -   5        $��lbCollaborateur��5$      $��0��5"      $��1��6#   $��2��61   $ �� IsSynchronizedWithCurrentItem$
 TrueY�5#      ��5%      �� *CollaborateurCollectionView+��5&      �� 5'      .R�5(      �� $ 
Horizontal=�6!   .+�5)      �� ��6$   �� *Nom+6;   �� 5*      $��
 10 0 0 0 q�6<   ��6$   �� *Prenom+6R   5+      5,      5.      (   "AnnuaireAgro.Views.ucCollaborateur  50   
   $��1��6    $��2��6-   $��0 0 0 90q�6k    � DataContext 6=   �� *CollaborateurSelected+6k   54      57      