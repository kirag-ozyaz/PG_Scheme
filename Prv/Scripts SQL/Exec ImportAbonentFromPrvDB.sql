declare --@date smalldatetime,
        @RC int,
        @i int, @CodeAbn int
declare cAbonentCalc cursor local scroll for
select  CodeAbonent
from PrvDb.dbo.tAbonent
--where codeAbonent > 400000 and codeabonent <= 450000
--where codeabonent <= 1510000
where codestreet = 761
BEGIN
open cAbonentCalc
  set @RC=@@cursor_rows
  set @i=1

  begin tran
    while @i<=@RC begin
    fetch absolute @i from cAbonentCalc into @CodeAbn

	exec ImportAbonentFromPrvDB @CodeAbn

    if (right(str(@i), 2) = '00')
	print 'Уже обработано ' + ltrim(str(@i)) + ' записей из ' + ltrim(str(@RC))
    

	if @@error<>0 begin
        print 'Случился какой-то 3.14дец!'
        rollback tran
        goto quit
      end
      set @i=@i+1
    end --while
  commit tran
  print 'Все записи обработаны! Ура!'
quit:
close cAbonentCalc
deallocate cAbonentCalc
END