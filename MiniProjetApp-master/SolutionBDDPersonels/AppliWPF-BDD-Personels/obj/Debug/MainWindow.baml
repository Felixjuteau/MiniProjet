   M S B A M L   `   `   `  ����Q  MAppliWPF-BDD-Personels, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:AppliWPF_BDD_PersonelsAppliWPF_BDD_Personels  5   	   '    !AppliWPF_BDD_Personels.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:AppliWPF_BDD_Personels     5   	     � Title$  Appli gestion personels��5   	   $	��450��6)   $	��800��66   
����h{�.��5
      �  � RowDefinitions 5   
   �� 5      $	��55* �6   �� 5      $
��379* �6    � ColumnDefinitions 5   
   �� 5      $
��180* �6   �� 5      $
��479* �6   �� 5      $
��141* �6   .+�5   
   �� -   5         ��Name$ BtnLogin��5      $��Login��6#   $
��Left=�63   $��26��6N   $��7,10,0,0q�6Z   $	��Top=�6l   $��44��6�   $��2��6�   �� 5   
   -   5        $ BtnTrier��5      $��Trier��6#   $
��Left=�63   $��18��6N   $��
358,12,0,0q�6Z   $	��Top=�6n   $��81��6�   $��1��6�   o� 5   
   -   5         o�Name$ MenuGest��5      $
��Left=�6!   $��27��6<   $��72,9,0,0q�6H   $	��Top=�6Z   $��44��6r   $��2��6}   .@�5      m� $
��Menu��6   .@�5      m� -   5         m�Name$ 
GestionBdd��5      $��Gestion de la Bdd��6H   6e   �� 5      6   m� 5      -   5        $ GestionFonctionsServices��5      $#��Gestion Fonctions et Services��6e   6�   m� 5      -   5        $ GestionPersonnels��5      $��Gestion Personnels��6V   6t   �� 5      6   m� 5       -   5        $ Déconnexion��5       $��Déconnexion��6K   6b   �� 5!      6   m� 5"      -   5        $ 	FermerApp��5"      $��Fermer l'application��6F    m� Icon 5#      �� 5$      $��fermerapp.png��6    5&      5(      5)      �� 5+   
   -	   5         ��Name$ TxtBRechercher��5+      $
��Left=�6*   $��22��6E   $��10,8,0,0q�6Q    �� TextWrapping$
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��188��6�   $��1��6�   �� 5-   
   -
   5        $ BtnRecherche��5-      $��
Rechercher��6'   $
��Left=�6<   $��25��6W   $��	196,6,0,0q�6c   $	��Top=�6v   $��63��6�   	 J� RenderTransformOrigin$	 0.5,0.5&�6�   $��1��6�   z�5.      V� 5/      .~�50      �� �� 51      �� 52      
 �� Angle$
 -0.651Q�6&   T� 53      54      56      �� 58   
   -   5         ��Name$ 
LbFonction��58      $
��Left=�6&   $	��169��6A   $��0,12,0,0q�6N   $	��Top=�6`   $	��176��6x   $��1��6�   �� 59   
   -   5        $ 
LbServices��59      $
��Left=�6&   $	��169��6A   $��	0,181,0,0q�6N   $	��Top=�6a   $	��176��6y   $��1��6�   �� 5<   
   -   5         ��Name$ CBxTypeRecherche��5<      $��1��6-   $
��Left=�6=   $��24��6X   $��	261,7,0,0q�6d   $	��Top=�6w   $��74��6�    � Cursor$  ��6�    �� SelectedIndex$ 0��6�   �� 5=   
   -   5        $ ListBoxTrom��5=      $��1��6'   $��0,6,0,29q�67   $��Disabled=�6I   $��Center=�6   $	��470��6�   $��1��6�   $	 0.5,0.5&�6�   z�5>      V� 5?      .~�5@      �� �� 5A      T� 5B      5C      ��5E      �� 5F      .R�5G      �  K� IsItemsHost . 6    5H      5J      5L      5M      