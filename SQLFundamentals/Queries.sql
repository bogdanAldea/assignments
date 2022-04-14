SELECT * FROM dbo.Buildings;


SELECT * FROM dbo.Apartments;


SELECT * FROM dbo.AddressLocations;


SELECT * FROM dbo.Tenants ORDER BY LastName;


SELECT FirstName, LastName
FROM dbo.Tenants
WHERE FirstName LIKE 'A%';


SELECT * FROM dbo.AddressLocations
WHERE PostalCode LIKE '123_%';



SELECT FirstName, LastName, Email
FROM dbo.Tenants
WHERE LastName LIKE 'Thryr';


SELECT COUNT(Id) as "Number of Apartments" , Residents FROM dbo.Apartments
WHERE BuildingId = 1
GROUP BY Residents
HAVING Residents > 1;


SELECT b.Capacity, a.StreetName, a.StreetNumber
FROM dbo.Buildings as b
LEFT JOIN dbo.AddressLocations as a
ON b.Id = a.BuildingId;


SELECT a.NumberInBuilding, t.FirstName, t.LastName
FROM dbo.Tenants as t
FULL JOIN dbo.Apartments as a
ON a.Id = t.ApartmentId
WHERE a.Residents > 0;