create proc uspGetTitleByKeywordAsc @title_name varchar(80)
as
select title, au_lname, au_fname, pub_name, price, notes, pubdate
from titles as t
inner join titleauthors as ta on t.title_id = ta.title_id
inner join authors as a on ta.au_id = a.au_id
inner join publishers as p on t.pub_id = p.pub_id
where title=@title_name
order by title asc 

exec uspGetTitleByKeywordAsc 'The Gourmet Microwave'
