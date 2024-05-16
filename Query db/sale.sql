select 
    s.id,c.Id,m.Id,m.name,b.ID,b.name,
	cl.id,cl.name,bd.ID,bd.name,c.mileage,
	c.FabYear,c.Cost,g.Id,g.name,
	s.Price,s.DateSale,
	clt.ID,
	clt.LastName,
	clt.firstName
	 from dbo.Sale_ s

left join Customer_ clt on s.CustomerID=clt.ID
left join CarInfo c on s.CarID=c.Id
left join BodyType_ bd on c.BodyID = bd.ID
left join Color cl on c.ColorID = cl.ID
left join Model m on c.ModelID = m.Id
left join [Gear Box] g on c.GearID =g.Id
left join Brand b on m.BrandID= b.ID
where s.DateSale  between  '2024-04-19' and '2024-04-25'

