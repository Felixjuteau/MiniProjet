   M S B A M L   `   `   `  ����Q  MAppliWPF-BDD-Personels, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:AppliWPF_BDD_PersonelsAppliWPF_BDD_Personels  5   	   '    !AppliWPF_BDD_Personels.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:AppliWPF_BDD_Personels     5   	     � Title$  Appli gestion personels��5   	   $	��450��6)   $	��800��66   .��5	      � $��	0,-13,0,0q�6    � RowDefinitions 5
   
   �� 5      $��0* �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ datagridServices��5      $��0,0,328,178q�6X   $��2��6m   �� 5   
   -   5         ��Name$ TBNom��5      $
��Left=�6!   $��555,167,0,0q�6<    �� TextWrapping$
 Wrap=�6Q   $��nom obligatoire��6e   $	��Top=�6|   $	��184��6�   $��1��6�   $��18��6�   �� 5   
   -   5        $ TBPrenom��5      $
��Left=�6$   $��555,185,0,0q�6?   $
 Wrap=�6T   $��prenom obligatoire��6h   $	��Top=�6�   $	��184��6�   $��1��6�   $��18��6�   �� 5   
   -   5        $ TBTelephone��5      $
��Left=�6'   $��555,203,0,0q�6B   $
 Wrap=�6W   $��telephone optionel��6k   $	��Top=�6�   $	��184��6�   $��1��6�   $��18��6�   �� 5   
   -   5        $ 	TBService��5      $
��Left=�6%   $��555,221,0,0q�6@   $
 Wrap=�6U   $��service obligatoire��6i   $	��Top=�6�   $	��184��6�   $��1��6�   $��18��6�   �� 5   
   -   5        $ 
TBFonction��5      $
��Left=�6&   $��555,239,0,0q�6A   $
 Wrap=�6V   $��fonction obligatoire��6j   $	��Top=�6�   $	��184��6�   $��1��6�   $��18��6�   �� 5   
   -   5        $��ajouter photo optionnel��5      $
��Left=�6H   $��555,275,0,0q�6c   $	��Top=�6x   $	��184��6�   $��1��6�   $��20��6�   �� 5   
   -   5         ��Name$ imagePicture��5      $
��Left=�6'   $	��100��6B   $��572,300,0,0q�6O   $	��Top=�6d   $	��153��6|   $��1��6�   �� 5   
   -	   5        $&�� Button envoyer nouveaux personel��5      $
��Left=�6<   $��167,332,0,0q�6W   $	��Top=�6l   $	��354��6�   $��47��6�   $��1��6�   �� 5   
   $
��Left=�6   $��236,300,0,0q�6/   $��2��6D   $
��Wrap=�6U   $��	TextBlock��6i   $	��Top=�6z   5      5      