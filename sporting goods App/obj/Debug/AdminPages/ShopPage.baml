   M S B A M L   `   `   `  ����M  Isporting goods App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:sporting_goods_Appsporting_goods_App  5      !    sporting_goods_App.ShopPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:sporting_goods_App     5        N� Title$  Магазины��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��5* �6   �� 5      $
��1.5* �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5        $��shopList��5       �� DisplayMemberPath$
 Name��6#   $��5q�6<   $��16(�6G   6�   �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��Center=�6X   .+�5      �� -   5        $��
btnShopAdd��5      $	��120��6'   $��14(�64   $
��5 10q�6B   $
��Left=�6P   ��5      �� 5      $%��Добавить магазин��6    $
��Wrap=�68    �� TextAlignment$ Center=�6L   5      �� 5      -   5        $��btnShopRemove��5      {�.  $	��120��6<   $��14(�6H   $
��5 10q�6V   .��6�   Удалить магазин6�   5      �� 5   
   $��2��6   $ 
Horizontal=�6"   $
��Left=�6;   $��Center=�6V   .+�5       �� $��16(�6   $��3 0 0 0q�6&   Поиск магазина:6I   �� 5!      -   5        $��txtShopFound��5!      $��16(�6*   $	��130��68   $	��5 0q�6D    �� TextWrapping$
 Wrap=�6R   6�   5"      �� 5#   
   -   5        $��	shopBlock��5#   h   $��1��6   $��0q�6%   $��Center=�60   $��Center=�6M   $y�Hidden=�6y   .+�5$      �� $	��130��6   $��/Images/SportShop.png��6!   �� 5%      -   5        $��txtName��5%      $
��Wrap=�6'   $��18(�6;   $	��Top=�6I   $��DemiBold"�6a   $��Center=�6w   Имя6�   �� 5&      $ 
Horizontal=�6   $��Center=�62   .+�5'      �� $	��Top=�6   $��16(�64   $
��Wrap=�6B   $
��Left=�6V   Адрес:6y   �� 5(      -   5        $��
txtAddress��5(      $	��200��6.   $	��Top=�6:   $��Center=�6R   $
��Wrap=�6o   $��16(�6�   $	��5 0q�6�   6�   5)      5*      5,      5-      