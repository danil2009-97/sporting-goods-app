   M S B A M L   `   `   `  ����M  Isporting goods App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:sporting_goods_Appsporting_goods_App  5      "    sporting_goods_App.LoginPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:sporting_goods_App     5        N� 
Background
  ����� N� Title$- 'Страница авторизации��5
      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      $
��0.5* �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��16(�6   $��Right=�6"   $	��10 q�6>   $��Bottom=�6K   Введите логин:6v   �� 5   
   -   5        $��textBoxLogin��5      $��1��6&   $��16(�66   $	��200��6D   $��Bottom=�6P   $
��Left=�6k   $	��10 q�6�    �� TextWrapping$
 Wrap=�6�   6�   �� 5   
   $��1��6   $��Right=�6!   $��10q�6=   $	��Top=�6I   $��16(�6a   Введите пароль:6�   G� 5   
   -   5        $��passwordBox��5      $	��Top=�6)   $
��Left=�6A   $��1��6\   $��1��6l   $	��200��6y   $��16(�6�   $	��10 q�6�   6�   �� 5   
   -   5        $��buttonLogin��5      $��1��6$   $��2��61   $��Center=�6E   $��4q�6`   $��Center=�6m   $��16(�6�   .��6�   .,Войти как администратор6�   �� 5   
   -   5        $��buttonGuest��5      $��1��6$   $��2��62   $	��200��6F   $��Bottom=�6R   $��Center=�6m   $��4q�6�   $��16(�6�   $��15q�6�   .��6�   Войти как гость6�   5      5      