   M S B A M L   `   `   `  ����G  CAnnuaireAgro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AnnuaireAgro.ViewsAnnuaireAgro.Views  5      (    "AnnuaireAgro.Views.ucCollaborateur   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:AnnuaireAgro.Views     5      .��5      �   � RowDefinitions  5      �� 5      $��* �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $	��100 �6#   �� 5      $
��Auto �6#   �� 5      $��* �6#   �� 5       $	��100 �6#   .+�5$   
   �� $��1��6   $��1��6    $��0 10 0 0q�6-   $	��Nom��6?   
�������6M   �� 5%   
   $��1��6   $��2��6    $��0 10 0 0q�6-   $��Prénom��6?   
�������6P   �� 5&   
   $��1��6   $��3��6    $��0 10 0 0q�6-   $
��Fixe��6?   
�������6N   �� 5'   
   $��1��6   $��4��6    $��0 10 0 0q�6-   $��Portable��6?   
�������6R   �� 5(   
   $��1��6   $��5��6    $��0 10 0 0q�6-   $��Email��6?   
�������6O   �� 5)   
   $��1��6   $��6��6    $��0 10 0 0q�6-   $
��Site��6?   
�������6N   �� 5*   
   $��1��6   $��7��6    $��0 10 0 0q�6-   $��Service��6?   
�������6Q   �� 5-   
   $��2��6   $��1��6"   $��0 10 0 0q�6/   ��6A   �� *Nom+ �� UpdateSourceTrigger$ PropertyChanged=��� 5.   
   $��2��6   $��2��6"   $��0 10 0 0q�6/   ��6A   �� *Prenom+$ PropertyChanged=��� 5/   
   $��2��6   $��3��6"   $��0 10 0 0q�6/   ��6A   �� *	TelFixe+$ PropertyChanged=��� 50   
   $��2��6   $��4��6"   $��0 10 0 0q�6/   ��6A   �� *TelPortable+$ PropertyChanged=��� 51   
   $��2��6   $��5��6"   $��0 10 0 0q�6/   ��6A   �� *Email+$ PropertyChanged=��� 52   
   -   5         ��Name$ txtSite��52      $��2��6e   $��6��6u   $��0 10 0 0q�6�   ��6%   �� *	FK_idSite+$ PropertyChanged=�6�   �� 53   
   -   5        $ 
txtService��53      $��2��6j   $��7��6z   $��0 10 0 0q�6�   ��6&   �� *FK_idService+$ PropertyChanged=�6�   56      59      