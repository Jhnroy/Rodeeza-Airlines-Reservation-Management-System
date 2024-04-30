-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 30, 2024 at 06:18 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `customer`
--

-- --------------------------------------------------------

--
-- Table structure for table `customertable_2`
--

CREATE TABLE `customertable_2` (
  `CustomerId` varchar(10) NOT NULL,
  `FlightId` varchar(20) DEFAULT NULL,
  `FirstName` varchar(15) DEFAULT NULL,
  `LastName` varchar(10) DEFAULT NULL,
  `Birthday` varchar(10) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `Email` varchar(30) DEFAULT NULL,
  `Phone` varchar(10) DEFAULT NULL,
  `Gender` varchar(6) DEFAULT NULL,
  `FlightClass` varchar(22) DEFAULT NULL,
  `Seats` varchar(5) DEFAULT NULL,
  `Destination` varchar(22) DEFAULT NULL,
  `Gate` varchar(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `customertable_2`
--

INSERT INTO `customertable_2` (`CustomerId`, `FlightId`, `FirstName`, `LastName`, `Birthday`, `Address`, `Email`, `Phone`, `Gender`, `FlightClass`, `Seats`, `Destination`, `Gate`) VALUES
('1032883429', 'FLIGHT-DV-1829773332', 'boa', 'hancock', '2024-04-24', 'Amazon Lily', 'boahancock223@gmail.com', '0932201154', 'Gender', '    Premium Economy Cl', '    1', '    Siquijor Island', 'Gate 2'),
('1303757717', 'FLIGHT-DV-1524981015', 'luffy', 'Dasda', '2024-04-24', 'talisay', 'test@email.com', '4445522212', 'Gender', '    First Class', '    2', '    Siquijor Island', 'Gate 5'),
('2045147838', 'FLIGHT-DV-2001765561', 'ronald', 'llofamia', '2024-04-24', 'hillcrest, labo, camarines norte', 'ulnok2233@gmail.com', '0988552247', 'Gender', '    Economy Class', '    1', '    Surigao City', 'Gate 2'),
('2055642275', 'FLIGHT-DV-2082426262', 'asdaadsaasd', 'asda', '2024-04-24', 'hillcrest, labo, camarines norte', 'ulnok2233@gmail.com', '0988552247', 'Gender', '    Economy Class', '    1', '    Surigao City', 'Gate 2'),
('2068904794', 'FLIGHT-DV-2004426931', 'jhon', 'louis', '2024-04-24', 'Paracale, Camarines Norte', 'jhonlouis988@gmail.com', '0955532441', 'Gender', '    First Class', '    2', '    Catanduanes', 'Gate 5'),
('2106738919', 'FLIGHT-DV-2072699805', 'khen', 'betito', '2024-08-27', 'daet camarines norte alawihao', 'khenmarkbetitomain@gmail.com', '0962055450', 'Gender', '    Premium First Clas', '    2', '    Manila', 'Gate 3'),
('2120301761', 'FLIGHT-DV-2014435169', 'dianne', 'asdaxxxc', '2024-04-24', 'labo', 'test@email.com', '0966588474', 'Gender', '    First Class', '    2', '    Roxas City', 'Gate 3'),
('2125742446', 'FLIGHT-DV-1895517099', 'luffyyy', 'monkey', '2024-04-24', 'Amazon Lily', 'boahancock223@gmail.com', '0932201154', 'Gender', '    Premium Economy Cl', '    1', '    Siquijor Island', 'Gate 2'),
('2147483522', 'FLIGHT-DV-2147483522', '    Gabriella', 'Simpson', '5/25/1987', '654 Walnut Street, Navotas City, Metro Manila', 'gabriella.simpson@example.com', '9567890123', 'Male', 'Business Class', '126F', 'Antique', 'Gate 3'),
('2147483523', 'FLIGHT-DU-2147483523', '    Ezekiel', 'Webb', '1/10/1973', '321 Cedar Street, Muntinlupa City, Metro Manila', 'ezekiel.webb@example.com', '9456789012', 'Male', 'Premium First Class', '125D', 'Roxas City', 'Gate 2'),
('2147483524', 'FLIGHT-DT-2147483524', '    Eliana', 'Wells', '9/2/1974', '789 Maple Street, Caloocan City, Metro Manila', 'eliana.wells@example.com', '9345678901', 'Female', 'Flexible Economy Class', '124B', 'Bacolod City', 'Gate 1'),
('2147483525', 'FLIGHT-DS-2147483525', '    Easton', 'Freeman', '3/15/1998', '456 Elm Street, San Juan City, Metro Manila', 'easton.freeman@example.com', '9234567890', 'Male', 'Economy Class', '123G', 'Iloilo City', 'Gate 5'),
('2147483526', 'FLIGHT-DR-2147483526', '    Morgan', 'Murray', '11/12/2005', '123 Oak Street, Marikina City, Metro Manila', 'morgan.murray@example.com', '9123456789', 'Male', 'Basic Economy Class', '122E', 'Zamboanga City', 'Gate 4'),
('2147483527', 'FLIGHT-DQ-2147483527', '    Robert', 'Gomez', '7/21/1981', '432 Pine Street, Pasay City, Metro Manila', 'robert.gomez@example.com', '9012345678', 'Male', 'Premium Business Class', '121C', 'Legazpi City', 'Gate 2'),
('2147483528', 'FLIGHT-DP-2147483528', '    Jasmine', 'Ortiz', '4/10/1990', '890 Birch Street, Parañaque City, Metro Manila', 'jasmine.ortiz@example.com', '9901234567', 'Female', 'Economy Plus Class', '120A', 'Batangas City', 'Gate 3'),
('2147483529', 'FLIGHT-DO-2147483529', '    Nicholas', 'Marshall', '10/21/1986', '567 Fir Street, Mandaluyong City, Metro Manila', 'nicholas.marshall@example.com', '9890123456', 'Male', 'First Class', '119F', 'Pampanga', 'Gate 5'),
('2147483530', 'FLIGHT-DN-2147483530', '    Alexis', 'Cruz', '6/4/1977', '234 Hemlock Street, Taguig City, Metro Manila', 'alexis.cruz@example.com', '9789012345', 'Female', 'Business Suite Class', '118D', 'Subic Bay', 'Gate 4'),
('2147483531', 'FLIGHT-DM-2147483531', '    Hudson', 'Mcdonald', '1/23/1979', '987 Chestnut Street, Manila City, Metro Manila', 'hudson.mcdonald@example.com', '9678901234', 'Male', 'Premium Economy Class', '117B', 'Dumaguete City', 'Gate 1'),
('2147483532', 'FLIGHT-DL-2147483532', '    Madeline', 'Gibson', '8/16/1994', '654 Spruce Street, Pasig City, Metro Manila', 'madeline.gibson@example.com', '9567890123', 'Female', 'Economy Class', '116G', 'Banaue Rice Terraces', 'Gate 3'),
('2147483533', 'FLIGHT-DK-2147483533', '    Jeremiah', 'Harrison', '5/11/2003', '321 Willow Street, Makati City, Metro Manila', 'jeremiah.harrison@example.com', '9456789012', 'Male', 'Flexible Economy Class', '115E', 'Coron', 'Gate 5'),
('2147483534', 'FLIGHT-DJ-2147483534', '    Alice', 'Ellis', '9/30/2004', '789 Cypress Street, Quezon City, Metro Manila', 'alice.ellis@example.com', '9345678901', 'Female', 'Business Class', '114C', 'Puerto Galera', 'Gate 4'),
('2147483535', 'FLIGHT-DI-2147483535', '    Ezra', 'Fisher', '3/11/1975', '456 Magnolia Street, Las Piñas City, Metro Manila', 'ezra.fisher@example.com', '9234567890', 'Female', 'Premium First Class', '113A', 'Sagada', 'Gate 2'),
('2147483536', 'FLIGHT-DH-2147483536', '    Eliana', 'Reynolds', '11/6/1980', '123 Ash Street, Malabon City, Metro Manila', 'eliana.reynolds@example.com', '9123456789', 'Female', 'Economy Plus Class', '112F', 'Camiguin Island', 'Gate 1'),
('2147483537', 'FLIGHT-DG-2147483537', '    Theodore', 'Owens', '7/15/1996', '432 Cherry Street, Valenzuela City, Metro Manila', 'theodore.owens@example.com', '9012345678', 'Male', 'Basic Economy Class', '111D', 'Batanes', 'Gate 4'),
('2147483538', 'FLIGHT-DF-2147483538', '    Valentina', 'Jordan', '4/22/2001', '890 Walnut Street, Navotas City, Metro Manila', 'valentina.jordan@example.com', '9901234567', 'Female', 'Premium Business Class', '110B', 'Vigan', 'Gate 5'),
('2147483539', 'FLIGHT-DE-2147483539', '    Cameron', 'West', '1/1/1989', '567 Cedar Street, Muntinlupa City, Metro Manila', 'cameron.west@example.com', '9890123456', 'Male', 'Economy Class', '109G', 'Tagaytay City', 'Gate 3'),
('2147483540', 'FLIGHT-DD-2147483540', '    Julia', 'Cole', '12/11/1973', '234 Maple Street, Caloocan City, Metro Manila', 'julia.cole@example.com', '9789012345', 'Female', 'First Class', '108E', 'Siargao Island', 'Gate 2'),
('2147483541', 'FLIGHT-DC-2147483541', '    Adrian', 'Woods', '8/26/1974', '987 Elm Street, San Juan City, Metro Manila', 'adrian.woods@example.com', '9678901234', 'Male', 'Business Suite Class', '107C', 'Bohol', 'Gate 1'),
('2147483542', 'FLIGHT-DB-2147483542', '    Isabelle', 'Wallace', '6/17/1998', '654 Oak Street, Marikina City, Metro Manila', 'isabelle.wallace@example.com', '9567890123', 'Female', 'Premium Economy Class', '106A', 'Davao City', 'Gate 2'),
('2147483543', 'FLIGHT-DA-2147483543', '    Landon', 'Sullivan', '2/28/2005', '321 Pine Street, Pasay City, Metro Manila', 'landon.sullivan@example.com', '9456789012', 'Male', 'Economy Plus Class', '105F', 'Baguio City', 'Gate 5'),
('2147483544', 'FLIGHT-CZ-2147483544', '    Ariana', 'Grande', '10/9/2002', '789 Birch Street, Parañaque City, Metro Manila', 'ariana.graham@example.com', '9345678901', 'Female', 'Flexible Economy Class', '104D', 'Cebu City', 'Gate 3'),
('2147483545', 'FLIGHT-CY-2147483545', '    Connor', 'Mcgregor', '4/26/1987', '456 Fir Street, Mandaluyong City, Metro Manila', 'connor.hamilton@example.com', '9234567890', 'Male', 'Business Class', '103B', 'Palawan', 'Gate 4'),
('2147483546', 'FLIGHT-CX-2147483546', '    Sarah', 'Ford', '1/5/1980', '123 Hemlock Street, Taguig City, Metro Manila', 'sarah.ford@example.com', '9123456789', 'Female', 'Premium First Class', '102G', 'Boracay Island', 'Gate 1'),
('2147483547', 'FLIGHT-CW-2147483547', '    Jonathan', 'Myers', '9/16/1991', '432 Chestnut Street, Manila City, Metro Manila', 'jonathan.myers@example.com', '9012345678', 'Male', 'Economy Class', '101E', 'Manila', 'Gate 4'),
('2147483548', 'FLIGHT-CV-2147483548', '    Piper', 'Hayes', '5/30/1986', '890 Spruce Street, Pasig City, Metro Manila', 'piper.hayes@example.com', '9901234567', 'Female', 'Basic Economy Class', '100C', 'Tawi-Tawi', 'Gate 5'),
('2147483549', 'FLIGHT-CU-2147483549', '    Eli', 'Diaz', '3/19/1973', '567 Willow Street, Makati City, Metro Manila', 'eli.diaz@example.com', '9890123456', 'Male', 'Premium Business Class', '99A', 'Masbate', 'Gate 3'),
('2147483550', 'FLIGHT-CT-2147483550', '    Genesis', 'Griffin', '11/22/1975', '234 Sycamore Street, Quezon City, Metro Manila', 'genesis.griffin@example.com', '9789012345', 'Male', 'Economy Plus Class', '98F', 'Sorsogon', 'Gate 2'),
('2147483551', 'FLIGHT-CS-2147483551', '    Hunter', 'Russell', '7/9/1982', '987 Cypress Street, Las Piñas City, Metro Manila', 'hunter.russell@example.com', '9678901234', 'Male', 'First Class', '97D', 'Camarines Sur', 'Gate 1'),
('2147483552', 'FLIGHT-CR-2147483552', '    Caroline', 'Alexander', '6/20/1999', '654 Magnolia Street, Malabon City, Metro Manila', 'caroline.alexander@example.com', '9567890123', 'Female', 'Business Suite Class', '96B', 'Camarines Norte', 'Gate 5'),
('2147483553', 'FLIGHT-CQ-2147483553', '    Christian', 'Bryant', '2/9/2006', '321 Ash Street, Valenzuela City, Metro Manila', 'christian.bryant@example.com', '9456789012', 'Male', 'Premium Economy Class', '95G', 'Albay', 'Gate 4'),
('2147483554', 'FLIGHT-CP-2147483554', '    Maya', 'Gonzales', '10/26/1988', '789 Cherry Street, Navotas City, Metro Manila', 'maya.gonzales@example.com', '9345678901', 'Female', 'Flexible Economy Class', '94E', 'Catanduanes', 'Gate 3'),
('2147483555', 'FLIGHT-CO-2147483555', '    Josiah', 'Foster', '4/3/1985', '456 Walnut Street, Muntinlupa City, Metro Manila', 'josiah.foster@example.com', '9234567890', 'Male', 'Economy Class', '93C', 'Palawan', 'Gate 2'),
('2147483556', 'FLIGHT-CN-2147483556', '    Anna', 'Simmons', '8/2/1981', '123 Cedar Street, Caloocan City, Metro Manila', 'anna.simmons@example.com', '9123456789', 'Female', 'Business Class', '92A', 'Romblon', 'Gate 1'),
('2147483557', 'FLIGHT-CM-2147483557', '    Caleb', 'Butler', '1/19/2000', '432 Maple Street, San Juan City, Metro Manila', 'caleb.butler@example.com', '9012345678', 'Male', 'Premium First Class', '91F', 'Oriental Mindoro', 'Gate 5'),
('2147483558', 'FLIGHT-CL-2147483558', '    Lucy', 'Washington', '12/28/1983', '890 Elm Street, Marikina City, Metro Manila', 'lucy.washington@example.com', '9901234567', 'Female', 'Economy Plus Class', '90D', 'Occidental Mindoro', 'Gate 2'),
('2147483559', 'FLIGHT-CK-2147483559', '    Charles', 'Flores', '9/11/1974', '567 Oak Street, Pasay City, Metro Manila', 'charles.flores@example.com', '9890123456', 'Male', 'Basic Economy Class', '89B', 'Marinduque', 'Gate 4'),
('2147483560', 'FLIGHT-CJ-2147483560', '    Claire', 'Hughes', '5/24/1979', '234 Pine Street, Parañaque City, Metro Manila', 'claire.hughes@example.com', '9789012345', 'Female', 'Premium Business Class', '88G', 'Quezon', 'Gate 3'),
('2147483561', 'FLIGHT-CI-2147483561', '    Isaiah', 'Patterson', '3/9/1996', '987 Birch Street, Mandaluyong City, Metro Manila', 'isaiah.patterson@example.com', '9678901234', 'Male', 'Economy Class', '87E', 'Batangas', 'Gate 1'),
('2147483562', 'FLIGHT-CH-2147483562', '    Aurora', 'Long', '11/16/2001', '654 Fir Street, Taguig City, Metro Manila', 'aurora.long@example.com', '9567890123', 'Female', 'First Class', '86C', 'Laguna', 'Gate 5'),
('2147483563', 'FLIGHT-CG-2147483563', '    Aaron', 'Powell', '6/27/2004', '321 Hemlock Street, Manila City, Metro Manila', 'aaron.powell@example.com', '9456789012', 'Male', 'Flexible Economy Class', '85A', 'Cavite', 'Gate 4'),
('2147483564', 'FLIGHT-CF-2147483564', '    Stella', 'Perry', '2/2/1975', '789 Chestnut Street, Pasig City, Metro Manila', 'stella.perry@example.com', '9345678901', 'Female', 'Business Suite Class', '84F', 'Rizal', 'Gate 2'),
('2147483565', 'FLIGHT-CE-2147483565', '    Nathan', 'Jenkins', '10/11/1976', '456 Spruce Street, Makati City, Metro Manila', 'nathan.jenkins@example.com', '9234567890', 'Male', 'Premium Economy Class', '83D', 'Metro Manila', 'Gate 1'),
('2147483566', 'FLIGHT-CD-2147483566', '    Samantha', 'Coleman', '7/28/1987', '123 Willow Street, Quezon City, Metro Manila', 'samantha.coleman@example.com', '9123456789', 'Female', 'Economy Plus Class', '82B', 'Bulacan', 'Gate 3'),
('2147483567', 'FLIGHT-CC-2147483567', '    Jaxon', 'Henderson', '4/15/1982', '432 Sycamore Street, Las Piñas City, Metro Manila', 'jaxon.henderson@example.com', '9012345678', 'Male', 'Business Class', '81G', 'Pampanga', 'Gate 4'),
('2147483568', 'FLIGHT-CB-2147483568', '    Zoe', 'Ross', '1/14/1977', '890 Cypress Street, Malabon City, Metro Manila', 'zoe.ross@example.com', '9901234567', 'Female', 'Premium First Class', '80E', 'Tarlac', 'Gate 5'),
('2147483569', 'FLIGHT-CA-2147483569', '    Ryan', 'Barnes', '9/3/1978', '567 Magnolia Street, Valenzuela City, Metro Manila', 'ryan.barnes@example.com', '9890123456', 'Male', 'Economy Class', '79C', 'Nueva Ecija', 'Gate 2'),
('2147483570', 'FLIGHT-BZ-2147483570', '    Skylar', 'Wood', '5/7/1993', '234 Ash Street, Navotas City, Metro Manila', 'skylar.wood@example.com', '9789012345', 'Female', 'Basic Economy Class', '78A', 'Aurora', 'Gate 1'),
('2147483571', 'FLIGHT-BY-2147483571', '    Mateo', 'Bennett', '11/18/2000', '987 Cherry Street, Muntinlupa City, Metro Manila', 'mateo.bennett@example.com', '9678901234', 'Male', 'Business Suite Class', '77F', 'Quirino', 'Gate 3'),
('2147483572', 'FLIGHT-BX-2147483572', '    Scarlett', 'Price', '6/24/1995', '654 Walnut Street, Caloocan City, Metro Manila', 'scarlett.price@example.com', '9567890123', 'Female', 'Flexible Economy Class', '76D', 'Isabela', 'Gate 4'),
('2147483573', 'FLIGHT-BW-2147483573', '    Lincoln', 'Sanders', '3/1/1983', '321 Cedar Street, San Juan City, Metro Manila', 'lincoln.sanders@example.com', '9456789012', 'Male', 'Premium Business Class', '75B', 'Cagayan', 'Gate 5'),
('2147483574', 'FLIGHT-BV-2147483574', '    Leah', 'Kelly', '12/12/1980', '789 Maple Street, Marikina City, Metro Manila', 'leah.kelly@example.com', '9345678901', 'Female', 'Economy Plus Class', '74G', 'Pangasinan', 'Gate 1'),
('2147483575', 'FLIGHT-BU-2147483575', '    Andrew', 'Brooks', '8/27/1986', '456 Elm Street, Pasay City, Metro Manila', 'andrew.brooks@example.com', '9234567890', 'Male', 'First Class', '73E', 'La Union', 'Gate 3'),
('2147483576', 'FLIGHT-BT-2147483576', '    Avery', 'Watson', '4/18/1973', '123 Oak Street, Parañaque City, Metro Manila', 'avery.watson@example.com', '9123456789', 'Female', 'Premium Economy Class', '72C', 'Ilocos Sur', 'Gate 2'),
('2147483577', 'FLIGHT-BS-2147483577', '    Joshua', 'James', '10/29/1974', '432 Pine Street, Mandaluyong City, Metro Manila', 'joshua.james@example.com', '9012345678', 'Male', 'Business Class', '71A', 'Ilocos Norte', 'Gate 5'),
('2147483578', 'FLIGHT-BR-2147483578', '    Hailey', 'Ramirez', '7/5/1997', '890 Birch Street, Taguig City, Metro Manila', 'hailey.ramirez@example.com', '9901234567', 'Female', 'Economy Class', '70F', 'Abra', 'Gate 3'),
('2147483579', 'FLIGHT-BQ-2147483579', '    Christopher', 'Gray', '1/30/2001', '567 Fir Street, Manila City, Metro Manila', 'christopher.gray@example.com', '9890123456', 'Male', 'Premium First Class', '69D', 'Apayao', 'Gate 4'),
('2147483580', 'FLIGHT-BP-2147483580', '    Aria', 'Peterson', '5/3/2004', '234 Hemlock Street, Pasig City, Metro Manila', 'aria.peterson@example.com', '9789012345', 'Female', 'Business Suite Class', '68B', 'Kalinga', 'Gate 1'),
('2147483581', 'FLIGHT-BO-2147483581', '    Julian', 'Torres', '9/22/1985', '987 Chestnut Street, Makati City, Metro Manila', 'julian.torres@example.com', '9678901234', 'Male', 'Flexible Economy Class', '67G', 'Mountain Province', 'Gate 2'),
('2147483582', 'FLIGHT-BN-2147483582', '    Natalie', 'Ward', '6/11/1992', '654 Spruce Street, Quezon City, Metro Manila', 'natalie.ward@example.com', '9567890123', 'Female', 'Basic Economy Class', '66E', 'Ifugao', 'Gate 5'),
('2147483583', 'FLIGHT-BM-2147483583', '    Gabriel', 'Howard', '3/8/1999', '321 Willow Street, Las Piñas City, Metro Manila', 'gabriel.howard@example.com', '9456789012', 'Male', 'Economy Plus Class', '65C', 'Benguet', 'Gate 4'),
('2147483584', 'FLIGHT-BL-2147483584', '    Ellie', 'Cox', '11/5/2002', '789 Cypress Street, Malabon City, Metro Manila', 'ellie.cox@example.com', '9345678901', 'Female', 'Business Class', '64A', 'Aurora', 'Gate 2'),
('2147483585', 'FLIGHT-BK-2147483585', '    Anthony', 'Richardson', '7/14/2006', '456 Magnolia Street, Valenzuela City, Metro Manila', 'anthony.richardson@example.com', '9234567890', 'Male', 'Premium Economy Class', '63F', 'Quirino', 'Gate 3'),
('2147483586', 'FLIGHT-BJ-2147483586', '    Aubrey', 'Cooper', '12/29/1987', '123 Ash Street, Navotas City, Metro Manila', 'aubrey.cooper@example.com', '9123456789', 'Female', 'Economy Class', '62D', 'Nueva Vizcaya', 'Gate 1'),
('2147483587', 'FLIGHT-BI-2147483587', '    Isaac', 'Rivera', '8/10/1981', '432 Cherry Street, Muntinlupa City, Metro Manila', 'isaac.rivera@example.com', '9012345678', 'Male', 'First Class', '61B', 'Bulacan', 'Gate 4'),
('2147483588', 'FLIGHT-BH-2147483588', '    Addison', 'Bailey', '5/20/1988', '890 Walnut Street, Caloocan City, Metro Manila', 'addison.bailey@example.com', '9901234567', 'Female', 'Flexible Economy Class', '60G', 'Rizal Province', 'Gate 5'),
('2147483589', 'FLIGHT-BG-2147483589', '    Levi', 'Murphy', '2/5/1974', '567 Cedar Street, San Juan City, Metro Manila', 'levi.murphy@example.com', '9890123456', 'Male', 'Business Suite Class', '59E', 'Laguna', 'Gate 2'),
('2147483590', 'FLIGHT-BF-2147483590', '    Lillian', 'Bell', '10/20/1973', '234 Maple Street, Marikina City, Metro Manila', 'lillian.bell@example.com', '9789012345', 'Female', 'Premium Business Class', '58C', 'Cavite', 'Gate 3'),
('2147483591', 'FLIGHT-BE-2147483591', '    Grayson', 'Morgan', '12/1/1989', '987 Elm Street, Pasay City, Metro Manila', 'grayson.morgan@example.com', '9678901234', 'Male', 'Economy Plus Class', '57A', 'Batangas', 'Gate 1'),
('2147483592', 'FLIGHT-BD-2147483592', '    Hannah', 'Cook', '9/12/1996', '654 Oak Street, Parañaque City, Metro Manila', 'hannah.cook@example.com', '9567890123', 'Female', 'Basic Economy Class', '56F', 'Quezon Province', 'Gate 5'),
('2147483593', 'FLIGHT-BC-2147483593', '    Dylan', 'Reed', '6/23/2001', '321 Pine Street, Mandaluyong City, Metro Manila', 'dylan.reed@example.com', '9456789012', 'Male', 'Premium First Class', '55D', 'Camarines Norte', 'Gate 4'),
('2147483594', 'FLIGHT-BB-2147483594', '    Eleanor', 'Rogers', '3/28/1998', '789 Birch Street, Taguig City, Metro Manila', 'eleanor.rogers@example.com', '9345678901', 'Female', 'Economy Class', '54B', 'Camarines Sur', 'Gate 3'),
('2147483595', 'FLIGHT-BA-2147483595', '    Jack', 'Coul', '1/13/1995', '456 Fir Street, Manila City, Metro Manila', 'jack.morris@example.com', '9234567890', 'Male', 'Business Class', '53G', 'Albay', 'Gate 2'),
('2147483596', 'FLIGHT-AZ-2147483596', '    Lily', 'Sanchez', '8/17/1976', '123 Hemlock Street, Pasig City, Metro Manila', 'lily.sanchez@example.com', '9123456789', 'Female', 'Premium Economy Class', '52E', 'Sorsogon', 'Gate 5'),
('2147483597', 'FLIGHT-AY-2147483597', '    Owen', 'Quilatan', '5/28/1977', '432 Chestnut Street, Makati City, Metro Manila', 'owen.stewart@example.com', '9012345678', 'Male', 'First Class', '51C', 'Masbate', 'Gate 4'),
('2147483598', 'FLIGHT-AX-2147483598', '    Nora', 'Aunor', '11/15/1991', '890 Spruce Street, Quezon City, Metro Manila', 'nora.collins@example.com', '9901234567', 'Female', 'Flexible Economy Class', '50A', 'Zambales', 'Gate 1'),
('2147483599', 'FLIGHT-AW-2147483599', '    Luke', 'Edwards', '9/8/2003', '567 Willow Street, Las Piñas City, Metro Manila', 'luke.edwards@example.com', '9890123456', 'Male', 'Business Suite Class', '49F', 'Pampanga', 'Gate 3'),
('2147483600', 'FLIGHT-AV-2147483600', '    Riley', 'Reid', '7/26/2000', '234 Sycamore Street, Malabon City, Metro Manila', 'riley.evans@example.com', '9789012345', 'Female', 'Economy Plus Class', '48D', 'Tarlac City', 'Gate 5'),
('2147483601', 'FLIGHT-AU-2147483601', '    John', 'Parker', '4/1/1985', '987 Cypress Street, Valenzuela City, Metro Manila', 'john.parker@example.com', '9678901234', 'Male', 'Premium Business Class', '47B', 'Pangasinan', 'Gate 1'),
('2147483602', 'FLIGHT-AT-2147483602', '    Layla', 'Campbell', '12/22/1983', '654 Magnolia Street, Navotas City, Metro Manila', 'layla.campbell@example.com', '9567890123', 'Female', 'Economy Class', '46G', 'Isabela', 'Gate 4'),
('2147483603', 'FLIGHT-AS-2147483603', '    Jayden', 'Phillips', '6/6/1982', '321 Ash Street, Muntinlupa City, Metro Manila', 'jayden.phillips@example.com', '9456789012', 'Male', 'Basic Economy Class', '45E', 'Nueva Ecija', 'Gate 2'),
('2147483604', 'FLIGHT-AR-2147483604', '    Penelope', 'Turner', '2/11/1979', '789 Cherry Street, Caloocan City, Metro Manila', 'penelope.turner@example.com', '9345678901', 'Male', 'First Class', '44C', 'Bataan', 'Gate 3'),
('2147483605', 'FLIGHT-AQ-2147483605', '    Wyatt', 'Roberts', '10/10/1993', '456 Walnut Street, San Juan City, Metro Manila', 'wyatt.roberts@example.com', '9234567890', 'Male', 'Premium Economy Class', '43A', 'San Fernando, La Union', 'Gate 1'),
('2147483606', 'FLIGHT-AP-2147483606', '    Zoey', 'Perez', '3/31/1980', '123 Cedar Street, Marikina City, Metro Manila', 'zoey.perez@example.com', '9123456789', 'Female', 'Flexible Economy Class', '42F', 'San Juan, La Union', 'Gate 5'),
('2147483607', 'FLIGHT-AO-2147483607', '    Sebastian', 'Gomez', '1/24/1986', '432 Maple Street, Pasay City, Metro Manila', 'sebastian.mitchell@example.com', '9012345678', 'Male', 'Economy Plus Class', '41D', 'Baler', 'Gate 2'),
('2147483608', 'FLIGHT-AN-2147483608', '    Luna', 'Carter', '8/21/1984', '890 Elm Street, Parañaque City, Metro Manila', 'luna.carter@example.com', '9901234567', 'Female', 'Business Suite Class', '40B', 'Vigan', 'Gate 4'),
('2147483609', 'FLIGHT-AM-2147483609', '    Carter', 'Nelson', '11/2/2005', '567 Oak Street, Mandaluyong City, Metro Manila', 'carter.nelson@example.com', '9890123456', 'Male', 'Business Class', '39G', 'Laoag City', 'Gate 3'),
('2147483610', 'FLIGHT-AL-2147483610', '    Madison', 'Gonzalez', '7/30/1992', '234 Pine Street, Taguig City, Metro Manila', 'madison.gonzalez@example.com', '9789012345', 'Female', 'Economy Class', '38E', 'Tuguegarao City', 'Gate 5'),
('2147483611', 'FLIGHT-AK-2147483611', '    David', 'Baker', '4/5/1999', '987 Birch Street, Manila City, Metro Manila', 'david.baker@example.com', '9678901234', 'Male', 'Premium First Class', '37C', 'Samar', 'Gate 2'),
('2147483612', 'FLIGHT-AJ-2147483612', '    Victoria', 'Adams', '5/16/2006', '654 Fir Street, Pasig City, Metro Manila', 'victoria.adams@example.com', '9567890123', 'Female', 'Basic Economy Class', '36A', 'Leyte', 'Gate 1'),
('2147483613', 'FLIGHT-AI-2147483613', '    Samuel', 'Green', '9/27/1981', '321 Hemlock Street, Makati City, Metro Manila', 'samuel.green@example.com', '9456789012', 'Male', 'Premium Economy Class', '35F', 'Tacloban City', 'Gate 4'),
('2147483614', 'FLIGHT-AH-2147483614', '    Chloe', 'Scott', '1/7/2001', '789 Chestnut Street, Quezon City, Metro Manila', 'chloe.scott@example.com', '9345678901', 'Female', 'Business Class', '34B', 'Ormoc City', 'Gate 5'),
('2147483615', 'FLIGHT-AG-2147483615', '    Jackson', 'Hill', '3/12/1987', '456 Spruce Street, Las Piñas City, Metro Manila', 'jackson.hill@example.com', '9234567890', 'Male', 'Economy Plus Class', '33D', 'Calbayog City', 'Gate 3'),
('2147483616', 'FLIGHT-AF-2147483616', '    Grace', 'Lopez', '6/26/1974', '123 Willow Street, Malabon City, Metro Manila', 'grace.lopez@example.com', '9123456789', 'Female', 'First Class', '32H', 'Bicol Region', 'Gate 2'),
('2147483617', 'FLIGHT-AE-2147483617', '    Joseph', 'Wright', '10/17/1975', '432 Sycamore Street, Valenzuela City, Metro Manila', 'joseph.wright@example.com', '9012345678', 'Male', 'Premium Business Class', '24E', 'Marinduque', 'Gate 1'),
('2147483618', 'FLIGHT-AD-2147483618', '    Scarlett', 'King', '2/3/1994', '890 Cypress Street, Navotas City, Metro Manila', 'scarlett.king@example.com', '9901234567', 'Female', 'Flexible Economy Class', '13C', 'Butuan City', 'Gate 4'),
('2147483619', 'FLIGHT-AC-2147483619', '    Henry', 'Hernandez', '8/8/1980', '567 Magnolia Street, Muntinlupa City, Metro Manila', 'henry.hernandez@example.com', '9890123456', 'Male', 'Business Suite Class', '27A', 'Surigao City', 'Gate 4'),
('2147483620', 'FLIGHT-AB-2147483620', '    Ella', 'Era', '11/19/1990', '234 Ash Street, Caloocan City, Metro Manila', 'ella.young@example.com', '9789012345', 'Male', 'Economy Class', '19F', 'Siquijor Island', 'Gate 5'),
('2147483621', 'FLIGHT-AA-2147483621', '    Daniel', 'Allen', '9/4/2000', '987 Cherry Street, San Juan City, Metro Manila', 'daniel.allen@example.com', '9678901234', 'Male', 'Basic Economy Class', '4B', 'Catanduanes', 'Gate 3'),
('2147483622', 'FLIGHT-Z-2147483622', '    Sofia', 'Hall', '7/25/2003', '654 Walnut Street, Marikina City, Metro Manila', 'sofia.hall@example.com', '9567890123', 'Female', 'Business Class', '22D', 'Antique', 'Gate 2'),
('2147483623', 'FLIGHT-Y-2147483623', '    Elijah', 'Walker', '4/14/1983', '321 Cedar Street, Pasay City, Metro Manila', 'elijah.walker@example.com', '9456789012', 'Male', 'Premium First Class', '16G', 'Roxas City', 'Gate 1'),
('2147483624', 'FLIGHT-X-2147483624', '    Avery', 'Lee', '1/29/1982', '789 Maple Street, Parañaque City, Metro Manila', 'avery.lee@example.com', '9345678901', 'Female', 'Economy Plus Class', '1C', 'Bacolod City', 'Gate 5'),
('2147483625', 'FLIGHT-W-2147483625', '    Michael', 'Lewis', '12/8/1976', '456 Elm Street, Mandaluyong City, Metro Manila', 'michael.lewis@example.com', '9234567890', 'Male', 'Business Suite Class', '28A', 'Iloilo City', 'Gate 3'),
('2147483626', 'FLIGHT-V-2147483626', '    Emily', 'Rodriguez', '5/9/1977', '123 Oak Street, Taguig City, Metro Manila', 'emily.rodriguez@example.com', '9123456789', 'Female', 'Premium Economy Class', '15H', 'Zamboanga City', 'Gate 2'),
('2147483627', 'FLIGHT-U-2147483627', '    William', 'Clark', '3/22/2005', '432 Pine Street, Manila City, Metro Manila', 'william.clark@example.com', '9012345678', 'Male', 'Flexible Economy Class', '2E', 'Legazpi City', 'Gate 4'),
('2147483628', 'FLIGHT-T-2147483628', '    Abigail', 'Robinson', '8/3/1991', '890 Birch Street, Pasig City, Metro Manila', 'abigail.robinson@example.com', '9901234567', 'Female', 'Economy Class', '26B', 'Batangas City', 'Gate 1'),
('2147483629', 'FLIGHT-S-2147483629', '    Benjamin', 'Martinez', '6/15/1996', '567 Fir Street, Makati City, Metro Manila', 'benjamin.martinez@example.com', '9890123456', 'Male', 'Economy Plus Class', '10D', 'Pampanga', 'Gate 3'),
('2147483630', 'FLIGHT-R-2147483630', '    Evelyn', 'Garcia', '10/2/1984', '234 Hemlock Street, Quezon City, Metro Manila', 'evelyn.garcia@example.com', '9789012345', 'Female', 'Business Class', '21G', 'Subic Bay', 'Gate 2'),
('2147483631', 'FLIGHT-Q-2147483631', '    Alexander', 'Thompson', '11/13/1992', '987 Chestnut Street, Las Piñas City, Metro Manila', 'alexander.thompson@example.com', '9678901234', 'Male', 'First Class', '6F', 'Dumaguete City', 'Gate 4'),
('2147483632', 'FLIGHT-P-2147483632', '    Harper', 'Martin', '2/20/2004', '654 Spruce Street, Malabon City, Metro Manila', 'harper.martin@example.com', '9567890123', 'Male', 'Business Suite Class', '25C', 'Banaue Rice Terraces', 'Gate 5'),
('2147483633', 'FLIGHT-O-2147483633', '    James', 'Harris', '7/1/2000', '321 Willow Street, Valenzuela City, Metro Manila', 'james.harris@example.com', '9456789012', 'Male', 'Premium Business Class', '11A', 'Coron', 'Gate 1'),
('2147483634', 'FLIGHT-N-2147483634', '    Amelia', 'White', '9/6/1995', '789 Sycamore Street, Navotas City, Metro Manila', 'amelia.white@example.com', '9345678901', 'Female', 'Premium Economy Class', '18H', 'Puerto Galera', 'Gate 3'),
('2147483635', 'FLIGHT-M-2147483635', '    Ethan', 'Jackson', '1/11/1978', '456 Cypress Street, Muntinlupa City, Metro Manila', 'ethan.jackson@example.com', '9234567890', 'Male', 'Economy Class', '3E', 'Sagada', 'Gate 5'),
('2147483636', 'FLIGHT-L-2147483636', '    Charlotte', 'Thomas', '4/17/1988', '123 Magnolia Street, Caloocan City, Metro Manila', 'charlotte.thomas@example.com', '9123456789', 'Female', 'Business Class', '20B', 'Camiguin Island', 'Gate 4'),
('2147483637', 'FLIGHT-K-2147483637', '    Mason', 'Anderson', '10/28/1979', '432 Ash Street, San Juan City, Metro Manila', 'mason.anderson@example.com', '9012345678', 'Male', 'Economy Class', '9C', 'Batanes', 'Gate 2'),
('2147483638', 'FLIGHT-J-2147483638', '    Mia', 'Taylor', '6/10/1997', '890 Cherry Street, Marikina City, Metro Manila', 'mia.taylor@example.com', '9901234567', 'Female', 'Premium First Class', '30F', 'Vigan', 'Gate 3'),
('2147483639', 'FLIGHT-I-2147483639', '    Lucas', 'Moore', '8/19/1993', '567 Walnut Street, Pasay City, Metro Manila', 'lucas.moore@example.com', '9890123456', 'Male', 'Business Suite Class', '12D', 'Tagaytay City', 'Gate 5'),
('2147483640', 'FLIGHT-H-2147483640', '    Isabella', 'Wilson', '3/5/1998', '234 Cedar Street, Parañaque City, Metro Manila', 'isabella.wilson@example.com', '9789012345', 'Female', 'Premium Business Class', '5A', 'Siargao Island', 'Gate 4'),
('2147483641', 'FLIGHT-G-2147483641', '    Oliver', 'Miller', '12/25/2001', '987 Birch Street, Mandaluyong City, Metro Manila', 'oliver.miller@example.com', '9678901234', 'Male', 'Economy Plus Class', '29G', 'Bohol', 'Gate 2'),
('2147483642', 'FLIGHT-F-2147483642', '    Sophia', 'Davis', '7/12/1985', '654 Maple Street, Taguig City, Metro Manila', 'sophia.davis@example.com', '9567890123', 'Female', 'Flexible Economy Class', '17E', 'Davao City', 'Gate 1'),
('2147483643', 'FLIGHT-E-2147483643', '    Elijah', 'Brown', '11/30/1986', '321 Pine Street, Manila City, Metro Manila', 'elijah.brown@example.com', '9456789012', 'Male', 'Basic Economy Class', '8B', 'Baguio City', 'Gate 4'),
('2147483644', 'FLIGHT-D-2147483644', '    Ava', 'Jones', '9/23/1989', '789 Oak Street, Pasig City, Metro Manila', 'ava.jones@example.com', '9345678901', 'Female', 'First Class', '31D', 'Cebu City', 'Gate 2'),
('2147483645', 'FLIGHT-C-2147483645', '    Noah', 'Williams', '5/1/2002', '456 Elm Street, Makati City, Metro Manila', 'noah.williams@example.com', '9234567890', 'Male', 'Business Class', '14F', 'Palawan', 'Gate 5'),
('2147483646', 'FLIGHT-B-2147483646', '    Olivia', 'Johnson', '2/14/2006', '123 Main Street, Quezon City, Metro Manila', 'olivia.johnson@example.com', '9123456789', 'Female', 'Premium Economy Class', '7C', 'Boracay Island', 'Gate 3'),
('2147483647', 'FLIGHT-A-2147483647', '    Liam', 'Smith', '2/1/2002', '325 Main Pasig City, Metro Manila', 'liam.smith@example.com', '9215478854', 'Male', 'Economy Class', '23A', 'Manila', 'Gate 1'),
('4643VE', '9741ZKA', 'busngag', 'Lukatoy', '2024-04-23', 'labo', 'test@email.com', '0963589521', 'Gender', '    Premium Economy Cl', '    1', '    Siquijor Island', 'Gate 2'),
('7706RT', '6284HPL', 'John', 'Doe', '2024-04-23', 'Labo', 'testemail@gmail.com', '123556678', 'Gender', '    Premium Economy Cl', '    2', '    Marinduque', 'Gate 3'),
('7854', '7854JWU', 'kodak', 'black', '2024-04-24', 'labo', 'test@email.com', '0333665588', 'Gender', '    Economy Class', '    2', '    Siquijor Island', 'Gate 2'),
('8948WT', '8285ZHX', 'sawako1', 'asada', '2024-04-23', 'tokyo, japan', 'test@email.com', '0932575621', 'Gender', '    Business Class', '    1', '    Antique', 'Gate 1');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customertable_2`
--
ALTER TABLE `customertable_2`
  ADD PRIMARY KEY (`CustomerId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
