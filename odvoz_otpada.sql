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
INSERT INTO `__migrationhistory` VALUES ('202002100926168_InitialCreate','OdvozOtpada.Migrations.Configuration',_binary '�\0\0\0\0\0\0\�\\\�n\�6}/\��X�V.\�\�6�[�N\�\�\\�\�}[\�\�+��D�I�~Y�I���%�7��\�)XX\��\�p8$�\�a������Oq\�<\�41��G�Cׁ\�\�A��7\'��߹\��\�\� ~r~�\�Nm����@Hr\�y��\0c��\�\�Oq�d\�\�\�������<H!\\�\�8\�9\"a��9\�ȇ	\�At�e��\�\�\nT\�\�0K�\'\�m����%	���v��(T���\�*\�\�\�\�H�\�r�\�\�?\'�\�-@�A.�\�ܶ+�Ǭ+ުa\�\��qO���On���\�ZwT{T\�\���\�\�Ľ\n`Q�GT2\�\�i�2\�{]�8˒HFU\�Q	y�R�\�q�y\�D<p�\�Զt<:d��i�<�s��\���\�\�Q\���\��g�&\'G�\�ɻ7oAp��x�\�S\�WJ\'Т�\'0���E\�\��\�v�ܰn\�hSj�\���s\r�\�C�$t\��s�\��	U	7��(���6\"iN?o�(�\��^+O�\�\�7o\�z\�e1�:qR:�>���\�¤�^\�x\�d�)�ٷh_e\�\�S�uI\�A��D�n쭌\�ʤ\��f]�\�i3IU�֒��3*۞\r��/\�\�\�\�Β�^aZL#m�nV#���ӠY�Α�\� ڥ��Jx�0\Z`)�\�B��E�ư\�\��\Z@�e�YFW�\�\'�=��N ��yJ\rtF@��8���\�Mϙ\�o�\�`Cs�;�>�\�b�6\�{��\�8\'(8~$~\�>\�\�\�`q\�|f\�%5fL1u�+�+DN�{ñj׮\�4a��E���SE��G��Ob \��%m��\�\�ىZ��E-):E\�d}Ee`v�rJ��A��%\�`�^1Bûz\���z�mަ���\�]!\���.c� �h56\�\�.��b�\�ߛ\nN��(�\�Z��X��\r\��φBLZ�\�+�8\0U\�ފ^�\�s�d۞B7�\�|;k�i��e�\�bhB_<p!\�O}8�;�Q�F��ЎQCٖGKh\�\\٨n\�9� �Ι_�� �A���v(\�!X��j[EDD\�RxRK�)k\�!(�35DD�!�\�D�Z�ZZna�\�5�\�&1����a��0j>Ҡtih\�5,�\�\r^�i̻\\\�ո+q��\�d�\�l�K�a�kl\�ٮ���](?�\�\Z�|p\�7�NL\�.\�VT\�\�TTɫ3\��j;�\�yu\�\�S<(o[oU\�lS\�Ǟ�f\�{\�6����j�\�sV	��\�pF\�\�糌����0�$b\�f\�\�j�P�D6�6���u��k@H�P=��by�\�q/�lwk�\�k�۰�y\� 4_�\�\�iu��{V[�b\�V���\� \�\�K츅RLqYU16�po�\�1>-\n\��\\\rJ�:3��*\�\�֒\�!\�\�m�%\�}2h�\�\�\�Z\�6ڭ$�S\�\�-\�HE\�>\�d�\"�nS׍�2K��=C:\��\Z$I����*^\�\�\�ܪ\�׳�IGq�\���&����\�Dp\n�P������a��s@��8\�4�2\�\�jX�+�\�\�S\�j��\�ﲅ\��^\�kUg�c\\\�\�̣)\�\��\�7wX��@��\�Oq�\�\�\�`�[��w\��e��0�$�Jі\�抪�\ZuR4H����@�!LꮼϦ\�M��\nP5QLA��\r�ɑ\�5X��\��:^f^�Ĕ&\0/\�\�\�mP�\Zu��b�IS��G�rL��RU)��$��͊��\Z\�S\�sPsG�\�j�=�&��	��^[#�\\g��I4ik�\�WY\'�\"�\�;��\��\�Un7ۻ/�\"��5\��@�\�X��^\�\�{iM\�\�\�\�T\�46�&�y\�n�Ņ��\�ތ)\\i�{ە���;�e(<��\�^��ݘ��\�(���\�u*5N\�\�\�\�oшՏ��\�(�l�(�\n0#e����\�\�\�ϛ/˂Hs85=�\�lY\���H\���\rލ�@�\��\n\�\�\���huZD1د����\�>��Vܧ9t�R�=�ɣ�x�Q�׫xa��_?�M�۔ΦS\�PR�:\�/>�\�%M\�ti\�~>�zg��6A�*͖��\"\�1�y�a*Yq!\�O,\�3�u�4��\ZFi�k����\�\�R\�\�\�þ�\�?XKR\�ˁ��\�\rدDU\�nE�3\�6V�Bϝy\�%a\�z{Rҳם�j��Ҡ\�՛�&�,iy�=S��<�.��\���%�x\�\�6\�x�Y\�-7I��\�\�=H�Ӥ�\�>�x۶f\n�\�yf�D\�=36�\�\�>x\�\�f�ﹱ�J�\�3[\�\���cK�\�Bw�«f#�pt\�\�\�2\�>q�9�FPz�\�\�J}NX[>k\����9Mf�L��B\�ζ__��\�\�YN\�\�֐\�\�ƛ����9M;oCb\�.�������\�u�-o\�5%=\�\�]\��Y[\�\�_S\�� Jf�\�Z���\n��!�N�\�`���?\�H�\�,\\� ؟fD\�v͚\�\n-p�yKU$R�\�\Z\�-�,%\���V��s�4��\���9�\�mN��\�.\�x	/\���/�E�Ƿ	�ʆ\�3d\��[�CFA-��&&d�`\��$,ػ|��n0�\�ꫝ�{\'\�n\�<\�ud�\��.����\0�@�BT��<\�\�\�X���Ԇ��\��\0����T\0\0','6.2.0-61023'),('202002100940004_DodanGrad','OdvozOtpada.Migrations.Configuration',_binary '�\0\0\0\0\0\0\�\\\�n\�6}/\��X�V.\�\�6�[�N\�\�\\�\�}[\�\�+��D�I�~Y�I���%�7��\�)XX\��\�p8$�\�a������Oq\�<\�41��G�Cׁ\�\�A��7\'��߹\��\�\� ~r~�\�Nm����@Hr\�y��\0c��\�\�Oq�d\�\�\�������<H!\\�\�8\�9\"a��9\�ȇ	\�At�e��\�\�\nT\�\�0K�\'\�m����%	���v��(T���\�*\�\�\�\�H�\�r�\�\�?\'�\�-@�A.�\�ܶ+�Ǭ+ުa\�\��qO���On���\�ZwT{T\�\���\�\�Ľ\n`Q�GT2\�\�i�2\�{]�8˒HFU\�Q	y�R�\�q�y\�D<p�\�Զt<:d��i�<�s��\���\�\�Q\���\��g�&\'G�\�ɻ7oAp��x�\�S\�WJ\'Т�\'0���E\�\��\�v�ܰn\�hSj�\���s\r�\�C�$t\��s�\��	U	7��(���6\"iN?o�(�\��^+O�\�\�7o\�z\�e1�:qR:�>���\�¤�^\�x\�d�)�ٷh_e\�\�S�uI\�A��D�n쭌\�ʤ\��f]�\�i3IU�֒��3*۞\r��/\�\�\�\�Β�^aZL#m�nV#���ӠY�Α�\� ڥ��Jx�0\Z`)�\�B��E�ư\�\��\Z@�e�YFW�\�\'�=��N ��yJ\rtF@��8���\�Mϙ\�o�\�`Cs�;�>�\�b�6\�{��\�8\'(8~$~\�>\�\�\�`q\�|f\�%5fL1u�+�+DN�{ñj׮\�4a��E���SE��G��Ob \��%m��\�\�ىZ��E-):E\�d}Ee`v�rJ��A��%\�`�^1Bûz\���z�mަ���\�]!\���.c� �h56\�\�.��b�\�ߛ\nN��(�\�Z��X��\r\��φBLZ�\�+�8\0U\�ފ^�\�s�d۞B7�\�|;k�i��e�\�bhB_<p!\�O}8�;�Q�F��ЎQCٖGKh\�\\٨n\�9� �Ι_�� �A���v(\�!X��j[EDD\�RxRK�)k\�!(�35DD�!�\�D�Z�ZZna�\�5�\�&1����a��0j>Ҡtih\�5,�\�\r^�i̻\\\�ո+q��\�d�\�l�K�a�kl\�ٮ���](?�\�\Z�|p\�7�NL\�.\�VT\�\�TTɫ3\��j;�\�yu\�\�S<(o[oU\�lS\�Ǟ�f\�{\�6����j�\�sV	��\�pF\�\�糌����0�$b\�f\�\�j�P�D6�6���u��k@H�P=��by�\�q/�lwk�\�k�۰�y\� 4_�\�\�iu��{V[�b\�V���\� \�\�K츅RLqYU16�po�\�1>-\n\��\\\rJ�:3��*\�\�֒\�!\�\�m�%\�}2h�\�\�\�Z\�6ڭ$�S\�\�-\�HE\�>\�d�\"�nS׍�2K��=C:\��\Z$I����*^\�\�\�ܪ\�׳�IGq�\���&����\�Dp\n�P������a��s@��8\�4�2\�\�jX�+�\�\�S\�j��\�ﲅ\��^\�kUg�c\\\�\�̣)\�\��\�7wX��@��\�Oq�\�\�\�`�[��w\��e��0�$�Jі\�抪�\ZuR4H����@�!LꮼϦ\�M��\nP5QLA��\r�ɑ\�5X��\��:^f^�Ĕ&\0/\�\�\�mP�\Zu��b�IS��G�rL��RU)��$��͊��\Z\�S\�sPsG�\�j�=�&��	��^[#�\\g��I4ik�\�WY\'�\"�\�;��\��\�Un7ۻ/�\"��5\��@�\�X��^\�\�{iM\�\�\�\�T\�46�&�y\�n�Ņ��\�ތ)\\i�{ە���;�e(<��\�^��ݘ��\�(���\�u*5N\�\�\�\�oшՏ��\�(�l�(�\n0#e����\�\�\�ϛ/˂Hs85=�\�lY\���H\���\rލ�@�\��\n\�\�\���huZD1د����\�>��Vܧ9t�R�=�ɣ�x�Q�׫xa��_?�M�۔ΦS\�PR�:\�/>�\�%M\�ti\�~>�zg��6A�*͖��\"\�1�y�a*Yq!\�O,\�3�u�4��\ZFi�k����\�\�R\�\�\�þ�\�?XKR\�ˁ��\�\rدDU\�nE�3\�6V�Bϝy\�%a\�z{Rҳם�j��Ҡ\�՛�&�,iy�=S��<�.��\���%�x\�\�6\�x�Y\�-7I��\�\�=H�Ӥ�\�>�x۶f\n�\�yf�D\�=36�\�\�>x\�\�f�ﹱ�J�\�3[\�\���cK�\�Bw�«f#�pt\�\�\�2\�>q�9�FPz�\�\�J}NX[>k\����9Mf�L��B\�ζ__��\�\�YN\�\�֐\�\�ƛ����9M;oCb\�.�������\�u�-o\�5%=\�\�]\��Y[\�\�_S\�� Jf�\�Z���\n��!�N�\�`���?\�H�\�,\\� ؟fD\�v͚\�\n-p�yKU$R�\�\Z\�-�,%\���V��s�4��\���9�\�mN��\�.\�x	/\���/�E�Ƿ	�ʆ\�3d\��[�CFA-��&&d�`\��$,ػ|��n0�\�ꫝ�{\'\�n\�<\�ud�\��.����\0�@�BT��<\�\�\�X���Ԇ��\��\0����T\0\0','6.2.0-61023'),('202006092250460_ModelUlicaChanged','OdvozOtpada.Migrations.Configuration',_binary '�\0\0\0\0\0\0\�\\\�n\�6}/\��X�V.\�\�6�[�N\�\�\\�\�}[\�\�+��D�I�~Y�I���%�7��\�)XX\��\�p8$�\�a������Oq\�<\�41��G�Cׁ\�\�A��7\'��߹\��\�\� ~r~�\�Nm����@Hr\�y��\0c��\�\�Oq�d\�\�\�������<H!\\�\�8\�9\"a��9\�ȇ	\�At�e��\�\�\nT\�\�0K�\'\�m����%	���v��(T���\�*\�\�\�\�H�\�r�\�\�?\'�\�-@�A.�\�ܶ+�Ǭ+ުa\�\��qO���On���\�ZwT{T\�\���\�\�Ľ\n`Q�GT2\�\�i�2\�{]�8˒HFU\�Q	y�R�\�q�y\�D<p�\�Զt<:d��i�<�s��\���\�\�Q\���\��g�&\'G�\�ɻ7oAp��x�\�S\�WJ\'Т�\'0���E\�\��\�v�ܰn\�hSj�\���s\r�\�C�$t\��s�\��	U	7��(���6\"iN?o�(�\��^+O�\�\�7o\�z\�e1�:qR:�>���\�¤�^\�x\�d�)�ٷh_e\�\�S�uI\�A��D�n쭌\�ʤ\��f]�\�i3IU�֒��3*۞\r��/\�\�\�\�Β�^aZL#m�nV#���ӠY�Α�\� ڥ��Jx�0\Z`)�\�B��E�ư\�\��\Z@�e�YFW�\�\'�=��N ��yJ\rtF@��8���\�Mϙ\�o�\�`Cs�;�>�\�b�6\�{��\�8\'(8~$~\�>\�\�\�`q\�|f\�%5fL1u�+�+DN�{ñj׮\�4a��E���SE��G��Ob \��%m��\�\�ىZ��E-):E\�d}Ee`v�rJ��A��%\�`�^1Bûz\���z�mަ���\�]!\���.c� �h56\�\�.��b�\�ߛ\nN��(�\�Z��X��\r\��φBLZ�\�+�8\0U\�ފ^�\�s�d۞B7�\�|;k�i��e�\�bhB_<p!\�O}8�;�Q�F��ЎQCٖGKh\�\\٨n\�9� �Ι_�� �A���v(\�!X��j[EDD\�RxRK�)k\�!(�35DD�!�\�D�Z�ZZna�\�5�\�&1����a��0j>Ҡtih\�5,�\�\r^�i̻\\\�ո+q��\�d�\�l�K�a�kl\�ٮ���](?�\�\Z�|p\�7�NL\�.\�VT\�\�TTɫ3\��j;�\�yu\�\�S<(o[oU\�lS\�Ǟ�f\�{\�6����j�\�sV	��\�pF\�\�糌����0�$b\�f\�\�j�P�D6�6���u��k@H�P=��by�\�q/�lwk�\�k�۰�y\� 4_�\�\�iu��{V[�b\�V���\� \�\�K츅RLqYU16�po�\�1>-\n\��\\\rJ�:3��*\�\�֒\�!\�\�m�%\�}2h�\�\�\�Z\�6ڭ$�S\�\�-\�HE\�>\�d�\"�nS׍�2K��=C:\��\Z$I����*^\�\�\�ܪ\�׳�IGq�\���&����\�Dp\n�P������a��s@��8\�4�2\�\�jX�+�\�\�S\�j��\�ﲅ\��^\�kUg�c\\\�\�̣)\�\��\�7wX��@��\�Oq�\�\�\�`�[��w\��e��0�$�Jі\�抪�\ZuR4H����@�!LꮼϦ\�M��\nP5QLA��\r�ɑ\�5X��\��:^f^�Ĕ&\0/\�\�\�mP�\Zu��b�IS��G�rL��RU)��$��͊��\Z\�S\�sPsG�\�j�=�&��	��^[#�\\g��I4ik�\�WY\'�\"�\�;��\��\�Un7ۻ/�\"��5\��@�\�X��^\�\�{iM\�\�\�\�T\�46�&�y\�n�Ņ��\�ތ)\\i�{ە���;�e(<��\�^��ݘ��\�(���\�u*5N\�\�\�\�oшՏ��\�(�l�(�\n0#e����\�\�\�ϛ/˂Hs85=�\�lY\���H\���\rލ�@�\��\n\�\�\���huZD1د����\�>��Vܧ9t�R�=�ɣ�x�Q�׫xa��_?�M�۔ΦS\�PR�:\�/>�\�%M\�ti\�~>�zg��6A�*͖��\"\�1�y�a*Yq!\�O,\�3�u�4��\ZFi�k����\�\�R\�\�\�þ�\�?XKR\�ˁ��\�\rدDU\�nE�3\�6V�Bϝy\�%a\�z{Rҳם�j��Ҡ\�՛�&�,iy�=S��<�.��\���%�x\�\�6\�x�Y\�-7I��\�\�=H�Ӥ�\�>�x۶f\n�\�yf�D\�=36�\�\�>x\�\�f�ﹱ�J�\�3[\�\���cK�\�Bw�«f#�pt\�\�\�2\�>q�9�FPz�\�\�J}NX[>k\����9Mf�L��B\�ζ__��\�\�YN\�\�֐\�\�ƛ����9M;oCb\�.�������\�u�-o\�5%=\�\�]\��Y[\�\�_S\�� Jf�\�Z���\n��!�N�\�`���?\�H�\�,\\� ؟fD\�v͚\�\n-p�yKU$R�\�\Z\�-�,%\���V��s�4��\���9�\�mN��\�.\�x	/\���/�E�Ƿ	�ʆ\�3d\��[�CFA-��&&d�`\��$,ػ|��n0�\�ꫝ�{\'\�n\�<\�ud�\��.����\0�@�BT��<\�\�\�X���Ԇ��\��\0����T\0\0','6.2.0-61023');
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
INSERT INTO `grad` VALUES ('Čakovec',1),('Zagreb',2);
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
INSERT INTO `otpad` VALUES (1,'Plastika'),(2,'Željezo');
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
INSERT INTO `ulica` VALUES (1,'Zagrebačka',1),(2,'Varaždinska',2);
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
