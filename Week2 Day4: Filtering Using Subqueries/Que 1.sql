select * from building
where building_type_id =(
  select id
  from building_type
  where name='Library'
  )
  order by owner_name ASC;
