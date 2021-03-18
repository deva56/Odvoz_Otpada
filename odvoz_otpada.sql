-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: localhost    Database: odvoz_otpada
-- ------------------------------------------------------
-- Server version	8.0.23

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__migrationhistory`
--

DROP TABLE IF EXISTS `__migrationhistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__migrationhistory` (
  `MigrationId` varchar(150) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `ContextKey` varchar(300) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Model` longblob NOT NULL,
  `ProductVersion` varchar(32) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`MigrationId`,`ContextKey`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__migrationhistory`
--

LOCK TABLES `__migrationhistory` WRITE;
/*!40000 ALTER TABLE `__migrationhistory` DISABLE KEYS */;
INSERT INTO `__migrationhistory` VALUES ('202002100926168_InitialCreate','OdvozOtpada.Migrations.Configuration',_binary '‹\0\0\0\0\0\0\Ý\\\Ûn\ã6}/\ÐôX¤V.\Ý\Å6°[¤N\Ò\Ý\\°\Î}[\Ð\í+‘ªD¥I‹~YúIý…’%‹7‰²\Û)XX\äð\Ìp8$‡\ÃaþýûŸñ÷Oq\ä<\Â41š¸G£C×\È\ÇAˆ–7\'‹¯ß¹\ß÷\å\ã‹ ~r~©\èNm‰²‰û@Hr\êy™ÿ\0c\â\ÐOq†d\ä\ã\ØöŽ¿õŽŽ<H!\\Š\å8\ã9\"a‹ú9\ÅÈ‡	\ÉAte¼œ\Ö\Ì\nT\ç\Ä0K€\'\îmðˆÿ¸%	À¨¤v³(T’Œ®\Â*\ç\é\Ç\ÎHŠ\Ñr–\Ð\Ý?\'\Ò-@”A.ÿ\éŠÜ¶+‡Ç¬+Þªa\å\çÁqOÀ£®On¾–†\ÝZwT{T\Ë\ä™õº\Ð\àÄ½\n`QôGT2\Ã\Ói”2\â‰{]³8Ë’HFU\ÃQ	y™R¸\ßqúy\ÔD<p¬\ÛÔ¶t<:dÿœi‘<…s’‚\èÀ¹\Ë\çQ\èÿŸ\ïñgˆ&\'Gó\ÅÉ»7oApòöxò¦\ÙS\ÚWJ\'Ð¢»\'0¥²ÁE\Ý\×ñ\ÄvžÜ°n\ÖhSj…\Ú®s\rž\ÞC´$t\Â¿s\Ëð	U	7®(¤³ˆ6\"iN?oò(ó\Öõ^+Oö\×\ã7o\áz\Ãe1ô:qR:¯>À¨¨\ÍÂ¤œ^\Âx\âd—)ŽÙ·h_e\í§\ÎSŸuI\îAº„D”nì­Œ\×Ê¤\Ôðf]¡\î¿i3IUóÖ’²­3*Ûž\r•¼/\Ë\×\Ú\âÎ’„^aZL#m§nV#©õÓ Y™Î‘­\é Ú¥ÿóJxƒ0\Z`)´\àB½E˜Æ°\î\å˜\Z@½e¾YFW‚\à\'=´ˆN úúyJ\rtF@œ¼8·»Œ\àMÏ™\Ýo\×`Csÿ;¾>Á\éb­6\Æ{ý\Ï8\'(8~$~\È>\ï\Ã\Ø`q\Î|f\Ù%5fL1u²+À+DNŽ{Ã±j×®\È4a¬÷E¤¥ôSEºòGôŠOb \Óù%m¢¾\Ç\ËÙ‰Z‘šE-):E\åd}Ee`v’rJ³ A§œ%\Õ`ž^1BÃ»z\ìþûz›mÞ¦µ ¡\Æ]!\áÁ”.cÁ ¦h56\ë\Æ.œ…bø\Óß›\nN¿€(š\ÕZ³¡X†Ÿ\r\ìþÏ†BLZü\Ì+±8\0U\ÄÞŠ^¶\êžs’dÛžB7·\Í|;k€iºœeö\ÃbhB_<p!\ÊO}8§;ŠQöFŽ„ÐŽQCÙ–GKh\ß\\Ù¨n\Ñ9Œ Î™_†§ óA ª‘v(\è!Xµ£j[EDD\á¾RxRK‡)k\Ø!(£35DD!ò\ÃDZ’ZZna¬\ï5¹\æ&1†š°a®€0j>Ò tih\ì5,®\Ý\r^«iÌ»\\\ØÕ¸+q‰­\Ød‡\ïl°Kî¿½ˆa¶kl\ÆÙ®ŒÁ¼](?«\Ø\Z€|p\Ù7•NL\å.\ÕVT\Ô\ØTTÉ«3\Ðòˆj;þ\Òyu\ß\ÌS<(o[oU\×lS\ÐÇž™f\é{\Ò6„¶€©jž\çsV	Ÿˆ\æpF\å\äç³Œ»º²‰0ð$b\Èf\å\ïjýP¯D6¢6À•¡u€òk@H™P=„«by­\Òq/¢lwk…\åk¿Û°»y\Ú 4_š\Ê\Æiuú¨{V[ƒb\äV‡…Ž\Æ \ä\ÅKì¸…RLqYU16¾po¸\Ñ1>-\n\êð\\\rJª:3¸–*\Ó\ìÖ’\Î!\ë\ã’m¤%\É}2h©\ê\Ì\àZ\â6Ú­$S\Ð\Ã-\ØHE\â>\Ðd«\"õnS×½2KŠŒ=C:\Õø\Z$Iˆ–ô*^\â\Ì\ÊÜª\é×³þIGq‰\áù™&÷¨–¶\æDp\n–Pª¥¬©¤—aš‘s@À°8\Ï4ˆ2\í\ÞjXþ+–\Í\íS\Äj¨¨\Ùï²…\æò^\ØkUg„c\\\Ò\ÆÌ£)\Â\èšñ\×7wXºˆ@ª‰\ÜOq”\Ç\È\ì`™[—÷w\Íöe‰Š0ö$ùJÑ–\âæŠª·\ZuR4Hµÿ²þ@™!Lê®¼Ï¦\ÂM©¥\nP5QLA«\rœÉ‘\é5X²\Ø¬:^f^ñÄ”&\0/\ê‰\Ñ\ÈmPÀ\Zuö¨búIS¬±G”rLšRU)›™$‚ÍŠµð\Z\ÕS\ØsPsGš\èj­=²&‹¤	­©^[#³\\gªI4ikª\í±WY\'ò\"º\Ç;—ñ\ä²ö\ÖUn7Û»/³\"³õ5\îð›@\âžXü–^\ã\å{iM\Æ\Þ\Ú\ÖT\Æ46³&†y\ån¿Å…§õ\ÊÞŒ)\\i‹{Û•¾¯ŸÍ¾¨e(<™¤\æ^ô¤Ý˜®º\Ñ(§­’\Äu*5N\Ü\ë\ç\ÙoÑˆÕŠŸ\Ó(„l¯(®\n0#e‡ûŽ½\Þ\á\ìÏ›/Ë‚Hs85=Œ\ÇlY\è¤þH\Õüˆ\rÞ¬@•\Ðó\n\à\Ó\Äý³huZD1Ø¯¢øÀ¹\Ê>¢ð·œVÜ§9tþRó=‡É£·x¹Qú×«xa¯ò«_?•MœÛ”Î¦S\çPRô:\Ã/>”\è%M\Ùti\Ö~>ñzg›ð6A‹*Í–õŸ\"\Ì1Žy‡a*Yq!\ÕO,\í3ƒuÁ4¯€\ZFi¦kŸô“\Ï\îR\è‡\å«\ÚÃ¾\×?XKR\ãË‘\ß\rØ¯DU\ËnEš3\Ó6V¥BÏy\×%a\îz{RÒ³×ôjöµÒ \ÉÕ›ù&¯,iy°=S““<ö.­ý\Å‘÷%÷x\å­\ï6\åx›Y\Æ-7Iÿ«\ä\â=H‡Ó¤÷\ì>…xÛ¶f\ný\îyf¿D\á=36¾\Í\ï>x\Û\ÆfŠï¹±õJú\Ý3[\Û\Õþ¹cK³\ÞBwžÂ«f#®pt\á\ã®\Ý2\Ö>qƒ9¦FPz”\å\ËJ}NX[>k\Ã‰™©9Mf¬L…¯B\ÑÎ¶__ù†\ß\ÚYN\Ó\ÎÖ\Â\ÙÆ›¯ÿ­¼9M;oCb\ä.’‹µ©‰º„\ïŽu¬-o\ê5%=\é\È]\ïòY[\ï\ã_S\îð Jf\áZùõ¤\n¢’!§N\Ô`õ†˜î?\ÆH÷\ï,\\® ØŸfD\ÐvÍš\æ\n-pµyKU$R„\æ\Z\Ð-õ,%\áø„V³°sñ4¼ˆ\ç±û9®\ÐmN’œ\Ð.\Ãx	/\æ´ñ/òŸE™Ç·	ûÊ†\è3d\Ñû[ôCFA-÷¥&&d€`\Þò²±$,Ø»|®‘n0²\âê«¢{\'\Ën\Ñ<\Âud£\æ÷.ÿ¼Š\0š@ºBTûø<\Ë\Ä\ÇXµ§ŸÔ†ƒø\é»ÿ\0ö““T\0\0','6.2.0-61023'),('202002100940004_DodanGrad','OdvozOtpada.Migrations.Configuration',_binary '‹\0\0\0\0\0\0\Ý\\\Ûn\ã6}/\ÐôX¤V.\Ý\Å6°[¤N\Ò\Ý\\°\Î}[\Ð\í+‘ªD¥I‹~YúIý…’%‹7‰²\Û)XX\äð\Ìp8$‡\ÃaþýûŸñ÷Oq\ä<\Â41š¸G£C×\È\ÇAˆ–7\'‹¯ß¹\ß÷\å\ã‹ ~r~©\èNm‰²‰û@Hr\êy™ÿ\0c\â\ÐOq†d\ä\ã\ØöŽ¿õŽŽ<H!\\Š\å8\ã9\"a‹ú9\ÅÈ‡	\ÉAte¼œ\Ö\Ì\nT\ç\Ä0K€\'\îmðˆÿ¸%	À¨¤v³(T’Œ®\Â*\ç\é\Ç\ÎHŠ\Ñr–\Ð\Ý?\'\Ò-@”A.ÿ\éŠÜ¶+‡Ç¬+Þªa\å\çÁqOÀ£®On¾–†\ÝZwT{T\Ë\ä™õº\Ð\àÄ½\n`QôGT2\Ã\Ói”2\â‰{]³8Ë’HFU\ÃQ	y™R¸\ßqúy\ÔD<p¬\ÛÔ¶t<:dÿœi‘<…s’‚\èÀ¹\Ë\çQ\èÿŸ\ïñgˆ&\'Gó\ÅÉ»7oApòöxò¦\ÙS\ÚWJ\'Ð¢»\'0¥²ÁE\Ý\×ñ\ÄvžÜ°n\ÖhSj…\Ú®s\rž\ÞC´$t\Â¿s\Ëð	U	7®(¤³ˆ6\"iN?oò(ó\Öõ^+Oö\×\ã7o\áz\Ãe1ô:qR:¯>À¨¨\ÍÂ¤œ^\Âx\âd—)ŽÙ·h_e\í§\ÎSŸuI\îAº„D”nì­Œ\×Ê¤\Ôðf]¡\î¿i3IUóÖ’²­3*Ûž\r•¼/\Ë\×\Ú\âÎ’„^aZL#m§nV#©õÓ Y™Î‘­\é Ú¥ÿóJxƒ0\Z`)´\àB½E˜Æ°\î\å˜\Z@½e¾YFW‚\à\'=´ˆN úúyJ\rtF@œ¼8·»Œ\àMÏ™\Ýo\×`Csÿ;¾>Á\éb­6\Æ{ý\Ï8\'(8~$~\È>\ï\Ã\Ø`q\Î|f\Ù%5fL1u²+À+DNŽ{Ã±j×®\È4a¬÷E¤¥ôSEºòGôŠOb \Óù%m¢¾\Ç\ËÙ‰Z‘šE-):E\åd}Ee`v’rJ³ A§œ%\Õ`ž^1BÃ»z\ìþûz›mÞ¦µ ¡\Æ]!\áÁ”.cÁ ¦h56\ë\Æ.œ…bø\Óß›\nN¿€(š\ÕZ³¡X†Ÿ\r\ìþÏ†BLZü\Ì+±8\0U\ÄÞŠ^¶\êžs’dÛžB7·\Í|;k€iºœeö\ÃbhB_<p!\ÊO}8§;ŠQöFŽ„ÐŽQCÙ–GKh\ß\\Ù¨n\Ñ9Œ Î™_†§ óA ª‘v(\è!Xµ£j[EDD\á¾RxRK‡)k\Ø!(£35DD!ò\ÃDZ’ZZna¬\ï5¹\æ&1†š°a®€0j>Ò tih\ì5,®\Ý\r^«iÌ»\\\ØÕ¸+q‰­\Ød‡\ïl°Kî¿½ˆa¶kl\ÆÙ®ŒÁ¼](?«\Ø\Z€|p\Ù7•NL\å.\ÕVT\Ô\ØTTÉ«3\Ðòˆj;þ\Òyu\ß\ÌS<(o[oU\×lS\ÐÇž™f\é{\Ò6„¶€©jž\çsV	Ÿˆ\æpF\å\äç³Œ»º²‰0ð$b\Èf\å\ïjýP¯D6¢6À•¡u€òk@H™P=„«by­\Òq/¢lwk…\åk¿Û°»y\Ú 4_š\Ê\Æiuú¨{V[ƒb\äV‡…Ž\Æ \ä\ÅKì¸…RLqYU16¾po¸\Ñ1>-\n\êð\\\rJª:3¸–*\Ó\ìÖ’\Î!\ë\ã’m¤%\É}2h©\ê\Ì\àZ\â6Ú­$S\Ð\Ã-\ØHE\â>\Ðd«\"õnS×½2KŠŒ=C:\Õø\Z$Iˆ–ô*^\â\Ì\ÊÜª\é×³þIGq‰\áù™&÷¨–¶\æDp\n–Pª¥¬©¤—aš‘s@À°8\Ï4ˆ2\í\ÞjXþ+–\Í\íS\Äj¨¨\Ùï²…\æò^\ØkUg„c\\\Ò\ÆÌ£)\Â\èšñ\×7wXºˆ@ª‰\ÜOq”\Ç\È\ì`™[—÷w\Íöe‰Š0ö$ùJÑ–\âæŠª·\ZuR4Hµÿ²þ@™!Lê®¼Ï¦\ÂM©¥\nP5QLA«\rœÉ‘\é5X²\Ø¬:^f^ñÄ”&\0/\ê‰\Ñ\ÈmPÀ\Zuö¨búIS¬±G”rLšRU)›™$‚ÍŠµð\Z\ÕS\ØsPsGš\èj­=²&‹¤	­©^[#³\\gªI4ikª\í±WY\'ò\"º\Ç;—ñ\ä²ö\ÖUn7Û»/³\"³õ5\îð›@\âžXü–^\ã\å{iM\Æ\Þ\Ú\ÖT\Æ46³&†y\ån¿Å…§õ\ÊÞŒ)\\i‹{Û•¾¯ŸÍ¾¨e(<™¤\æ^ô¤Ý˜®º\Ñ(§­’\Äu*5N\Ü\ë\ç\ÙoÑˆÕŠŸ\Ó(„l¯(®\n0#e‡ûŽ½\Þ\á\ìÏ›/Ë‚Hs85=Œ\ÇlY\è¤þH\Õüˆ\rÞ¬@•\Ðó\n\à\Ó\Äý³huZD1Ø¯¢øÀ¹\Ê>¢ð·œVÜ§9tþRó=‡É£·x¹Qú×«xa¯ò«_?•MœÛ”Î¦S\çPRô:\Ã/>”\è%M\Ùti\Ö~>ñzg›ð6A‹*Í–õŸ\"\Ì1Žy‡a*Yq!\ÕO,\í3ƒuÁ4¯€\ZFi¦kŸô“\Ï\îR\è‡\å«\ÚÃ¾\×?XKR\ãË‘\ß\rØ¯DU\ËnEš3\Ó6V¥BÏy\×%a\îz{RÒ³×ôjöµÒ \ÉÕ›ù&¯,iy°=S““<ö.­ý\Å‘÷%÷x\å­\ï6\åx›Y\Æ-7Iÿ«\ä\â=H‡Ó¤÷\ì>…xÛ¶f\ný\îyf¿D\á=36¾\Í\ï>x\Û\ÆfŠï¹±õJú\Ý3[\Û\Õþ¹cK³\ÞBwžÂ«f#®pt\á\ã®\Ý2\Ö>qƒ9¦FPz”\å\ËJ}NX[>k\Ã‰™©9Mf¬L…¯B\ÑÎ¶__ù†\ß\ÚYN\Ó\ÎÖ\Â\ÙÆ›¯ÿ­¼9M;oCb\ä.’‹µ©‰º„\ïŽu¬-o\ê5%=\é\È]\ïòY[\ï\ã_S\îð Jf\áZùõ¤\n¢’!§N\Ô`õ†˜î?\ÆH÷\ï,\\® ØŸfD\ÐvÍš\æ\n-pµyKU$R„\æ\Z\Ð-õ,%\áø„V³°sñ4¼ˆ\ç±û9®\ÐmN’œ\Ð.\Ãx	/\æ´ñ/òŸE™Ç·	ûÊ†\è3d\Ñû[ôCFA-÷¥&&d€`\Þò²±$,Ø»|®‘n0²\âê«¢{\'\Ën\Ñ<\Âud£\æ÷.ÿ¼Š\0š@ºBTûø<\Ë\Ä\ÇXµ§ŸÔ†ƒø\é»ÿ\0ö““T\0\0','6.2.0-61023'),('202006092250460_ModelUlicaChanged','OdvozOtpada.Migrations.Configuration',_binary '‹\0\0\0\0\0\0\Ý\\\Ûn\ã6}/\ÐôX¤V.\Ý\Å6°[¤N\Ò\Ý\\°\Î}[\Ð\í+‘ªD¥I‹~YúIý…’%‹7‰²\Û)XX\äð\Ìp8$‡\ÃaþýûŸñ÷Oq\ä<\Â41š¸G£C×\È\ÇAˆ–7\'‹¯ß¹\ß÷\å\ã‹ ~r~©\èNm‰²‰û@Hr\êy™ÿ\0c\â\ÐOq†d\ä\ã\ØöŽ¿õŽŽ<H!\\Š\å8\ã9\"a‹ú9\ÅÈ‡	\ÉAte¼œ\Ö\Ì\nT\ç\Ä0K€\'\îmðˆÿ¸%	À¨¤v³(T’Œ®\Â*\ç\é\Ç\ÎHŠ\Ñr–\Ð\Ý?\'\Ò-@”A.ÿ\éŠÜ¶+‡Ç¬+Þªa\å\çÁqOÀ£®On¾–†\ÝZwT{T\Ë\ä™õº\Ð\àÄ½\n`QôGT2\Ã\Ói”2\â‰{]³8Ë’HFU\ÃQ	y™R¸\ßqúy\ÔD<p¬\ÛÔ¶t<:dÿœi‘<…s’‚\èÀ¹\Ë\çQ\èÿŸ\ïñgˆ&\'Gó\ÅÉ»7oApòöxò¦\ÙS\ÚWJ\'Ð¢»\'0¥²ÁE\Ý\×ñ\ÄvžÜ°n\ÖhSj…\Ú®s\rž\ÞC´$t\Â¿s\Ëð	U	7®(¤³ˆ6\"iN?oò(ó\Öõ^+Oö\×\ã7o\áz\Ãe1ô:qR:¯>À¨¨\ÍÂ¤œ^\Âx\âd—)ŽÙ·h_e\í§\ÎSŸuI\îAº„D”nì­Œ\×Ê¤\Ôðf]¡\î¿i3IUóÖ’²­3*Ûž\r•¼/\Ë\×\Ú\âÎ’„^aZL#m§nV#©õÓ Y™Î‘­\é Ú¥ÿóJxƒ0\Z`)´\àB½E˜Æ°\î\å˜\Z@½e¾YFW‚\à\'=´ˆN úúyJ\rtF@œ¼8·»Œ\àMÏ™\Ýo\×`Csÿ;¾>Á\éb­6\Æ{ý\Ï8\'(8~$~\È>\ï\Ã\Ø`q\Î|f\Ù%5fL1u²+À+DNŽ{Ã±j×®\È4a¬÷E¤¥ôSEºòGôŠOb \Óù%m¢¾\Ç\ËÙ‰Z‘šE-):E\åd}Ee`v’rJ³ A§œ%\Õ`ž^1BÃ»z\ìþûz›mÞ¦µ ¡\Æ]!\áÁ”.cÁ ¦h56\ë\Æ.œ…bø\Óß›\nN¿€(š\ÕZ³¡X†Ÿ\r\ìþÏ†BLZü\Ì+±8\0U\ÄÞŠ^¶\êžs’dÛžB7·\Í|;k€iºœeö\ÃbhB_<p!\ÊO}8§;ŠQöFŽ„ÐŽQCÙ–GKh\ß\\Ù¨n\Ñ9Œ Î™_†§ óA ª‘v(\è!Xµ£j[EDD\á¾RxRK‡)k\Ø!(£35DD!ò\ÃDZ’ZZna¬\ï5¹\æ&1†š°a®€0j>Ò tih\ì5,®\Ý\r^«iÌ»\\\ØÕ¸+q‰­\Ød‡\ïl°Kî¿½ˆa¶kl\ÆÙ®ŒÁ¼](?«\Ø\Z€|p\Ù7•NL\å.\ÕVT\Ô\ØTTÉ«3\Ðòˆj;þ\Òyu\ß\ÌS<(o[oU\×lS\ÐÇž™f\é{\Ò6„¶€©jž\çsV	Ÿˆ\æpF\å\äç³Œ»º²‰0ð$b\Èf\å\ïjýP¯D6¢6À•¡u€òk@H™P=„«by­\Òq/¢lwk…\åk¿Û°»y\Ú 4_š\Ê\Æiuú¨{V[ƒb\äV‡…Ž\Æ \ä\ÅKì¸…RLqYU16¾po¸\Ñ1>-\n\êð\\\rJª:3¸–*\Ó\ìÖ’\Î!\ë\ã’m¤%\É}2h©\ê\Ì\àZ\â6Ú­$S\Ð\Ã-\ØHE\â>\Ðd«\"õnS×½2KŠŒ=C:\Õø\Z$Iˆ–ô*^\â\Ì\ÊÜª\é×³þIGq‰\áù™&÷¨–¶\æDp\n–Pª¥¬©¤—aš‘s@À°8\Ï4ˆ2\í\ÞjXþ+–\Í\íS\Äj¨¨\Ùï²…\æò^\ØkUg„c\\\Ò\ÆÌ£)\Â\èšñ\×7wXºˆ@ª‰\ÜOq”\Ç\È\ì`™[—÷w\Íöe‰Š0ö$ùJÑ–\âæŠª·\ZuR4Hµÿ²þ@™!Lê®¼Ï¦\ÂM©¥\nP5QLA«\rœÉ‘\é5X²\Ø¬:^f^ñÄ”&\0/\ê‰\Ñ\ÈmPÀ\Zuö¨búIS¬±G”rLšRU)›™$‚ÍŠµð\Z\ÕS\ØsPsGš\èj­=²&‹¤	­©^[#³\\gªI4ikª\í±WY\'ò\"º\Ç;—ñ\ä²ö\ÖUn7Û»/³\"³õ5\îð›@\âžXü–^\ã\å{iM\Æ\Þ\Ú\ÖT\Æ46³&†y\ån¿Å…§õ\ÊÞŒ)\\i‹{Û•¾¯ŸÍ¾¨e(<™¤\æ^ô¤Ý˜®º\Ñ(§­’\Äu*5N\Ü\ë\ç\ÙoÑˆÕŠŸ\Ó(„l¯(®\n0#e‡ûŽ½\Þ\á\ìÏ›/Ë‚Hs85=Œ\ÇlY\è¤þH\Õüˆ\rÞ¬@•\Ðó\n\à\Ó\Äý³huZD1Ø¯¢øÀ¹\Ê>¢ð·œVÜ§9tþRó=‡É£·x¹Qú×«xa¯ò«_?•MœÛ”Î¦S\çPRô:\Ã/>”\è%M\Ùti\Ö~>ñzg›ð6A‹*Í–õŸ\"\Ì1Žy‡a*Yq!\ÕO,\í3ƒuÁ4¯€\ZFi¦kŸô“\Ï\îR\è‡\å«\ÚÃ¾\×?XKR\ãË‘\ß\rØ¯DU\ËnEš3\Ó6V¥BÏy\×%a\îz{RÒ³×ôjöµÒ \ÉÕ›ù&¯,iy°=S““<ö.­ý\Å‘÷%÷x\å­\ï6\åx›Y\Æ-7Iÿ«\ä\â=H‡Ó¤÷\ì>…xÛ¶f\ný\îyf¿D\á=36¾\Í\ï>x\Û\ÆfŠï¹±õJú\Ý3[\Û\Õþ¹cK³\ÞBwžÂ«f#®pt\á\ã®\Ý2\Ö>qƒ9¦FPz”\å\ËJ}NX[>k\Ã‰™©9Mf¬L…¯B\ÑÎ¶__ù†\ß\ÚYN\Ó\ÎÖ\Â\ÙÆ›¯ÿ­¼9M;oCb\ä.’‹µ©‰º„\ïŽu¬-o\ê5%=\é\È]\ïòY[\ï\ã_S\îð Jf\áZùõ¤\n¢’!§N\Ô`õ†˜î?\ÆH÷\ï,\\® ØŸfD\ÐvÍš\æ\n-pµyKU$R„\æ\Z\Ð-õ,%\áø„V³°sñ4¼ˆ\ç±û9®\ÐmN’œ\Ð.\Ãx	/\æ´ñ/òŸE™Ç·	ûÊ†\è3d\Ñû[ôCFA-÷¥&&d€`\Þò²±$,Ø»|®‘n0²\âê«¢{\'\Ën\Ñ<\Âud£\æ÷.ÿ¼Š\0š@ºBTûø<\Ë\Ä\ÇXµ§ŸÔ†ƒø\é»ÿ\0ö““T\0\0','6.2.0-61023');
/*!40000 ALTER TABLE `__migrationhistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetroles`
--

DROP TABLE IF EXISTS `aspnetroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetroles` (
  `Id` varchar(128) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Name` varchar(256) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `RoleNameIndex` (`Name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetroles`
--

LOCK TABLES `aspnetroles` WRITE;
/*!40000 ALTER TABLE `aspnetroles` DISABLE KEYS */;
INSERT INTO `aspnetroles` VALUES ('adminRola','Administrator');
/*!40000 ALTER TABLE `aspnetroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserclaims`
--

DROP TABLE IF EXISTS `aspnetuserclaims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetuserclaims` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `UserId` varchar(128) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `ClaimType` longtext,
  `ClaimValue` longtext,
  PRIMARY KEY (`Id`),
  KEY `IX_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserclaims`
--

LOCK TABLES `aspnetuserclaims` WRITE;
/*!40000 ALTER TABLE `aspnetuserclaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserclaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserlogins`
--

DROP TABLE IF EXISTS `aspnetuserlogins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(128) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `ProviderKey` varchar(128) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `UserId` varchar(128) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`LoginProvider`,`ProviderKey`,`UserId`),
  KEY `IX_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserlogins`
--

LOCK TABLES `aspnetuserlogins` WRITE;
/*!40000 ALTER TABLE `aspnetuserlogins` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserlogins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserroles`
--

DROP TABLE IF EXISTS `aspnetuserroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(128) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `RoleId` varchar(128) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`UserId`,`RoleId`),
  KEY `IX_UserId` (`UserId`),
  KEY `IX_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserroles`
--

LOCK TABLES `aspnetuserroles` WRITE;
/*!40000 ALTER TABLE `aspnetuserroles` DISABLE KEYS */;
INSERT INTO `aspnetuserroles` VALUES ('83c45051-622c-4dad-8d16-f3bee18fd20c','adminRola'),('cd6fb3d7-6e2f-475b-a9dc-d257a46a0658','adminRola');
/*!40000 ALTER TABLE `aspnetuserroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetusers`
--

DROP TABLE IF EXISTS `aspnetusers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetusers` (
  `Id` varchar(128) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Email` varchar(256) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` longtext,
  `SecurityStamp` longtext,
  `PhoneNumber` longtext,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEndDateUtc` datetime DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int NOT NULL,
  `UserName` varchar(256) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserNameIndex` (`UserName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetusers`
--

LOCK TABLES `aspnetusers` WRITE;
/*!40000 ALTER TABLE `aspnetusers` DISABLE KEYS */;
INSERT INTO `aspnetusers` VALUES ('83c45051-622c-4dad-8d16-f3bee18fd20c','Admin_Test2@mail.com',0,'ANl3Usb2J2iVql2Q4nYphXQ+DJJDLJLRvMdPw93u/rXUupfi6rw/1ZxL77EboutAsg==','8963d00f-d6da-4efb-9251-3875054c3fa4',NULL,0,0,NULL,1,0,'Admin_Test2'),('cd6fb3d7-6e2f-475b-a9dc-d257a46a0658','Admin_Test@mail.com',0,'AO4znvMgopUPO+D0pb8JPCywD06Wc8hVc7j58/ARkskkpt0A4oCqXYDtUiC93tQNhw==','33af7767-00c7-443e-9877-299a254947aa',NULL,0,0,NULL,1,0,'Admin_Test');
/*!40000 ALTER TABLE `aspnetusers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grad`
--

DROP TABLE IF EXISTS `grad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `grad` (
  `imeGrad` varchar(128) NOT NULL,
  `idGrad` int NOT NULL,
  PRIMARY KEY (`idGrad`),
  UNIQUE KEY `ImeGradaIndex` (`imeGrad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grad`
--

LOCK TABLES `grad` WRITE;
/*!40000 ALTER TABLE `grad` DISABLE KEYS */;
INSERT INTO `grad` VALUES ('ÄŒakovec',1),('Zagreb',2);
/*!40000 ALTER TABLE `grad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `otpad`
--

DROP TABLE IF EXISTS `otpad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `otpad` (
  `idOtpad` int NOT NULL,
  `vrstaOtpad` varchar(256) NOT NULL,
  PRIMARY KEY (`idOtpad`),
  UNIQUE KEY `vrstaOtpad_UNIQUE` (`vrstaOtpad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `otpad`
--

LOCK TABLES `otpad` WRITE;
/*!40000 ALTER TABLE `otpad` DISABLE KEYS */;
INSERT INTO `otpad` VALUES (1,'Plastika'),(2,'Å½eljezo');
/*!40000 ALTER TABLE `otpad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rasporedodvoza`
--

DROP TABLE IF EXISTS `rasporedodvoza`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rasporedodvoza` (
  `idRasporedaOdvoza` int NOT NULL,
  `idVrsteOtpada` int NOT NULL,
  `idUlice` int NOT NULL,
  `danTjednaOdvoza` varchar(45) NOT NULL,
  `vrijemeOdvoza` varchar(45) NOT NULL,
  `idGrad` int NOT NULL,
  `datumKreiranja` varchar(128) NOT NULL,
  `datumOdvoza` varchar(45) NOT NULL,
  PRIMARY KEY (`idRasporedaOdvoza`),
  KEY `idVrsteOtpada_FK_idx` (`idVrsteOtpada`),
  KEY `idUlice_FK_idx` (`idUlice`),
  KEY `idGrad_FK_idx` (`idGrad`),
  CONSTRAINT `idGrad_FK` FOREIGN KEY (`idGrad`) REFERENCES `grad` (`idGrad`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `idUlice_FK` FOREIGN KEY (`idUlice`) REFERENCES `ulica` (`idUlica`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `idVrsteOtpada_FK` FOREIGN KEY (`idVrsteOtpada`) REFERENCES `otpad` (`idOtpad`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rasporedodvoza`
--

LOCK TABLES `rasporedodvoza` WRITE;
/*!40000 ALTER TABLE `rasporedodvoza` DISABLE KEYS */;
INSERT INTO `rasporedodvoza` VALUES (1,1,2,'Utorak','06:00',2,'11/03/2021','18/03/2021'),(2,2,1,'Ponedjeljak','06:00',1,'11/03/2021','02/03/2021');
/*!40000 ALTER TABLE `rasporedodvoza` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ulica`
--

DROP TABLE IF EXISTS `ulica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ulica` (
  `idUlica` int NOT NULL,
  `imeUlica` varchar(256) NOT NULL,
  `idGrada` int NOT NULL,
  PRIMARY KEY (`idUlica`),
  KEY `idGrada_FK_idx` (`idGrada`),
  CONSTRAINT `idGrada_FK` FOREIGN KEY (`idGrada`) REFERENCES `grad` (`idGrad`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ulica`
--

LOCK TABLES `ulica` WRITE;
/*!40000 ALTER TABLE `ulica` DISABLE KEYS */;
INSERT INTO `ulica` VALUES (1,'ZagrebaÄka',1),(2,'VaraÅ¾dinska',2);
/*!40000 ALTER TABLE `ulica` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-03-18 22:57:01
