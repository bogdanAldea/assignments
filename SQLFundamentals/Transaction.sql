USE DemoDB;

BEGIN TRY
	BEGIN TRANSACTION

	UPDATE dbo.Buildings
	SET Capacity = 100
	WHERE Id = 5;

	UPDATE dbo.Apartments
	SET Residents = 10,
		SurfaceArea = 89.90
	WHERE BuildingId = 10;

	UPDATE dbo.AddressLocations
	SET City = 'Cluj',
		StreetName = 'Parang',
		StreetNumber = 14
	WHERE BuildingId = 10;

	DELETE FROM dbo.Tenants
	WHERE Id = 1;

	DELETE FROM dbo.Tenants
	WHERE Id = 15146;

	COMMIT TRANSACTION
END TRY

BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH