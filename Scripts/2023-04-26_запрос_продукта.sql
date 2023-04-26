


/*

� ���� ������ MS SQL Server ���� �������� � ���������. 
������ �������� ����� ��������������� ����� ���������, � ����� ��������� ����� ���� ����� ���������. 
�������� SQL ������ ��� ������ ���� ��� ���� �������� � ��� ���������. 
���� � �������� ��� ���������, �� ��� ��� ��� ����� ������ ����������.

Tables:

1. Products (id, Name)
2. Categories(id, Code, Name)
3. Product_Category (id, refProduct, refCategory)
*/


Select (p.Name +' - '+ ISNULL(c.Name,' [��� ���������] ')) as '��� �������� � ��� ���������'
from Products p
left join Product_Category cp on cp.refProduct=p.id
left join Categories c on c.id=cp.refCategory







