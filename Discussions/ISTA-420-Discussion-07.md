#### MSSA Cohort 3
#### Course: ISTA-420
#### Lesson Plan: 07
#### Name: Jason Bergener
#### Date: August 16, 2017

1. What is a table expression? Can you give a technical definition of a table expression?  
**A table expression is a named query expression that represents a valid relational table. You can use table expressions in data-manipulation statements much like you use other tables. T-SQL supports four types of table expressions: derived tables, common table expressions (CTEs), views, and inline table-valued functions (inline TVFs).**
1. In what SQL clause are derived tables (table valued subqueries) located?  
**Derived tables (also known as table subqueries) are defined in the FROM clause of an outer query.**
1. Why can you refer to column aliases in an outer query that you defined in an inner table valued subquery?  
**You can refer to column aliases in an outer query that you defined in an inner table valued subquery because as far as the outer query is concerned, it queries a table.**
1. What SQL key word defines a common table expression?  
**Common table expressions are defined by using a WITH statement.**
1. When using common table expressions, can a subsequent derived table use a table alias declared in a preceding table expression?  
**Each common table expression can refer to all previously defined common table expressions, and the outer query can refer to all common table expressions.**
1. Can a main query refer to a previously defined common table expression by multiple aliases?  
**As far as the FROM clause of the outer query is concerned, the common table expression already exists; therefore, you can refer to multiple instances of the same common table expression in table operators like joins.**
1. In SQL, is a view a durable object?  
**Views and inline table-valued functions are two types of table expressions whose definitions are stored as permanent objects in the database, making them reusable.**
1. In a view, what does WITH CHECK OPTION do? Why is this important?  
**The purpose of CHECK OPTION is to prevent modifications through the view that conflict with the view’s filter. It basically prevents using the view to make modifications that the view wouldn't return.**
1. In a view, what does SCHEMABINDING do? Why is this important?  
**SCHEMABINDING binds the schema of referenced objects and columns to the schema of the referencing object. It indicates that referenced objects cannot be dropped and that referenced columns cannot be dropped or altered. It helps prevent errors at run time from trying to query the view and referenced objects or columns do not exist**
1. What is a table valued function?  
**Inline table valued functions are reusable table expressions that support input parameters. In most respects, except for the support for input parameters, inline table valued functions are similar to views.**
1. What does the APPLY operator do?  
**The APPLY operator operates on two input tables; I’ll refer to them as the “left” and “right” tables. The right table is typically a derived table or a table valued function. The CROSS APPLY operator implements one logical-query processing phase—it applies the right table to each row from the left table and produces a result table with the unified result sets.**
1. What are the two forms of the APPLY operator? Give an example of each.  
**The two forms of the APPLY operator are CROSS APPLY and OUTER APPLY. For example, the following code uses the CROSS APPLY operator to return the three most recent orders for each customer:**
    ```sql
    SELECT C.custid, A.orderid, A.orderdate
    FROM Sales.Customers AS C
      CROSS APPLY
        (SELECT TOP (3) orderid, empid, orderdate, requireddate
         FROM Sales.Orders AS O
         WHERE O.custid = C.custid
         ORDER BY orderdate DESC, orderid DESC) AS A;
    ```
    **The following code returns the three most recent orders for each customer and include in the output customers who did not place orders:**
    ```sql
    SELECT C.custid, A.orderid, A.orderdate
    FROM Sales.Customers AS C
      OUTER APPLY
        (SELECT TOP (3) orderid, empid, orderdate, requireddate
         FROM Sales.Orders AS O
         WHERE O.custid = C.custid
         ORDER BY orderdate DESC, orderid DESC) AS A;
    ```