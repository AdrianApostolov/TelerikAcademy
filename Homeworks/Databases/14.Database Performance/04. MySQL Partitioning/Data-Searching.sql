SELECT COUNT(*) FROM Logs PARTITION (p0);
SELECT COUNT(*) FROM Logs PARTITION (p1);
SELECT COUNT(*) FROM Logs PARTITION (p2);
SELECT COUNT(*) FROM Logs PARTITION (p3);

RESET QUERY CACHE;
SELECT COUNT(*) FROM Logs WHERE YEAR(PublishDate) < 1980;

RESET QUERY CACHE;
SELECT COUNT(*) FROM Logs WHERE YEAR(PublishDate) >= 2010;

RESET QUERY CACHE;
SELECT COUNT(*) FROM Logs WHERE YEAR(PublishDate) > 1900;