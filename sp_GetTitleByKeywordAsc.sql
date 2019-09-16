create proc uspGetTitleByKeywordAsc @title_name varchar(80)
as
select t.title_id, title, au_lname, au_fname, pub_name, price, notes, pubdate
from titles as t
inner join titleauthors as ta on t.title_id = ta.title_id
inner join authors as a on ta.au_id = a.au_id
inner join publishers as p on t.pub_id = p.pub_id
where title like '%'+@title_name+'%'
order by title asc 

drop proc uspGetTitleByKeywordAsc

exec uspGetTitleByKeywordAsc 'rme'

create proc uspGetTitleByAuthorFullNameAsc @au_lname varchar(40), @au_fname varchar(20)
as
select t.title_id, title, au_lname, au_fname, pub_name, price, notes, pubdate
from titles as t
inner join titleauthors as ta on t.title_id = ta.title_id
inner join authors as a on ta.au_id = a.au_id
inner join publishers as p on t.pub_id = p.pub_id
where au_lname like '%'+@au_lname+'%' and au_fname like '%'+@au_fname+'%'
order by au_lname asc, au_fname asc

create proc uspGetTitleByAuthorNameAsc @au_name varchar(40)
as
select t.title_id, title, au_lname, au_fname, pub_name, price, notes, pubdate
from titles as t
inner join titleauthors as ta on t.title_id = ta.title_id
inner join authors as a on ta.au_id = a.au_id
inner join publishers as p on t.pub_id = p.pub_id
where au_lname like '%'+@au_name+'%' or au_fname like '%'+@au_name+'%'
order by au_lname asc, au_fname asc

drop proc uspGetTitleByAuthorNameAsc

exec uspGetTitleByAuthorNameAsc ''

exec uspGetTitleByAuthorFullNameAsc 'Rin', 'an'