/* All queries made with MySql 8 */
/* Max salary by Department */
select E.Name, max(Salary), D.Name
from Employee E
join Department D 
on E.DepartmentID = D.ID 
group by D.Name
order by Salary desc;

/* Department chiefs */
select E.Name as Department_Lead, D.Name
from Employee E
join Department D
on D.ID = E.DepartmentID
where ChiefID is null;

/* Department efficiency */
select D.Name, count(*)/Salary as Eff
from Employee E
join Department D 
on E.DepartmentID = D.ID 
group by D.Name
order by Eff desc;

/* Department tree depth */
with recursive cte as (
select 1 as lvl, chiefid, id, departmentid
from Employee
where ChiefID is null
union all
select lvl + 1, E.ChiefID, E.id, E.DepartmentID
from employee E
join cte C
on E.chiefid = C.id)
select max(lvl), name
from cte 
join department
on department.id = cte.departmentid
group by departmentid
