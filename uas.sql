-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 29, 2024 at 12:43 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `uas`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `username` varchar(25) NOT NULL,
  `password` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`username`, `password`) VALUES
('admin', 'user123');

-- --------------------------------------------------------

--
-- Table structure for table `dokter`
--

CREATE TABLE `dokter` (
  `id_dokter` varchar(3) NOT NULL,
  `nama_dokter` varchar(30) NOT NULL,
  `nip` varchar(20) NOT NULL,
  `poli` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `dokter`
--

INSERT INTO `dokter` (`id_dokter`, `nama_dokter`, `nip`, `poli`) VALUES
('001', 'dr. Rudi', '3335618639617889', 'Gigi'),
('002', 'dr. Guntur', '3331628718729187', 'Umum'),
('003', 'dr. Iwan', '3373770108802081', 'KIA'),
('004', 'dr. Cahyo', '3388938010082080', 'Lansia');

-- --------------------------------------------------------

--
-- Table structure for table `obat`
--

CREATE TABLE `obat` (
  `id_obat` varchar(3) NOT NULL,
  `nama_obat` varchar(25) NOT NULL,
  `harga_obat` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `obat`
--

INSERT INTO `obat` (`id_obat`, `nama_obat`, `harga_obat`) VALUES
('001', 'Paracetamol 500mg', 2000),
('002', 'Ambroxol tablet', 16),
('003', 'Ambroxol Sirup', 4500),
('005', 'Ampisilin sirup kering 12', 6000),
('006', 'Asam Mefenamat kapsul 250', 16500),
('007', 'Asam Folat Tablet 1 mg', 2000),
('008', 'Asiklovir krim 5%', 4000),
('009', 'Digoksin Tablet', 9000);

-- --------------------------------------------------------

--
-- Table structure for table `pasien`
--

CREATE TABLE `pasien` (
  `id_pasien` varchar(3) NOT NULL,
  `nama_pasien` varchar(30) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `ttl` varchar(35) NOT NULL,
  `gender` varchar(9) NOT NULL,
  `keluhan` varchar(100) NOT NULL,
  `nama_dokter` varchar(30) NOT NULL,
  `poli` varchar(20) NOT NULL,
  `jenis_pasien` varchar(4) NOT NULL,
  `status_pasien` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pasien`
--

INSERT INTO `pasien` (`id_pasien`, `nama_pasien`, `alamat`, `ttl`, `gender`, `keluhan`, `nama_dokter`, `poli`, `jenis_pasien`, `status_pasien`) VALUES
('001', 'Muhammad Majid', 'Mojosongo, Surakarta', 'Surakarta, 28/05/1998', 'Laki-Laki', 'Sakit Perut', 'dr. Guntur', 'Umum', 'Umum', 'Pulang'),
('002', 'Nayaka Akiela', 'Sragen Kota', 'Sragen, 14/04/2003', 'Laki-Laki', 'Gatal-gatal ', 'dr. Iwan', 'KIA', 'BPJS', 'Rujuk'),
('003', 'Bagas Harley', 'Bulukerto, Wonogiri', 'Wonogiri, 09/10/2002', 'Laki-Laki', 'Deman, Gatal-gatal, Tenggorokan sakit, Radang', 'dr. Guntur', 'Umum', 'BPJS', 'Pulang'),
('004', 'Opis', 'Banyudono', 'Surakarta, 1/11/1991', 'Laki-Laki', 'Panas', 'dr. Guntur', 'Umum', 'BPJS', 'Pulang');

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE `transaksi` (
  `id_transaksi` varchar(3) NOT NULL,
  `nama_pasien` varchar(30) NOT NULL,
  `tgl` date NOT NULL,
  `nama_dokter` varchar(30) NOT NULL,
  `jtindakan` varchar(30) NOT NULL,
  `biaya_tindakan` int(8) NOT NULL,
  `nama_obat` varchar(25) NOT NULL,
  `jumlah_obat` int(2) NOT NULL,
  `total_obat` int(8) NOT NULL,
  `total_biaya` int(8) NOT NULL,
  `username` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transaksi`
--

INSERT INTO `transaksi` (`id_transaksi`, `nama_pasien`, `tgl`, `nama_dokter`, `jtindakan`, `biaya_tindakan`, `nama_obat`, `jumlah_obat`, `total_obat`, `total_biaya`, `username`) VALUES
('001', 'Muhammad Majid', '2023-07-11', 'dr. Guntur', '', 0, 'Asam Mefenamat kapsul 250', 1, 16500, 23500, 'admin'),
('002', 'Nayaka Akiela', '2023-07-11', 'dr. Iwan', '', 0, 'Asiklovir krim 5%', 1, 4000, 4000, 'admin'),
('004', 'Opis', '2023-10-27', 'dr. Guntur', '', 0, 'Ampisilin sirup kering 12', 12, 72000, 72000, 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`username`),
  ADD KEY `username` (`username`);

--
-- Indexes for table `dokter`
--
ALTER TABLE `dokter`
  ADD PRIMARY KEY (`id_dokter`),
  ADD KEY `nama_dokter` (`nama_dokter`),
  ADD KEY `poli` (`poli`);

--
-- Indexes for table `obat`
--
ALTER TABLE `obat`
  ADD PRIMARY KEY (`id_obat`),
  ADD KEY `nama_obat` (`nama_obat`);

--
-- Indexes for table `pasien`
--
ALTER TABLE `pasien`
  ADD PRIMARY KEY (`id_pasien`),
  ADD KEY `nama_pasien` (`nama_pasien`),
  ADD KEY `poli` (`poli`),
  ADD KEY `nama_dokter` (`nama_dokter`);

--
-- Indexes for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id_transaksi`),
  ADD KEY `username` (`username`),
  ADD KEY `nama_pasien` (`nama_pasien`),
  ADD KEY `nama_dokter` (`nama_dokter`),
  ADD KEY `nama_obat` (`nama_obat`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `pasien`
--
ALTER TABLE `pasien`
  ADD CONSTRAINT `pasien_ibfk_1` FOREIGN KEY (`nama_dokter`) REFERENCES `dokter` (`nama_dokter`),
  ADD CONSTRAINT `pasien_ibfk_2` FOREIGN KEY (`poli`) REFERENCES `dokter` (`poli`);

--
-- Constraints for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD CONSTRAINT `transaksi_ibfk_1` FOREIGN KEY (`nama_obat`) REFERENCES `obat` (`nama_obat`),
  ADD CONSTRAINT `transaksi_ibfk_2` FOREIGN KEY (`nama_dokter`) REFERENCES `dokter` (`nama_dokter`),
  ADD CONSTRAINT `transaksi_ibfk_3` FOREIGN KEY (`nama_pasien`) REFERENCES `pasien` (`nama_pasien`),
  ADD CONSTRAINT `transaksi_ibfk_4` FOREIGN KEY (`username`) REFERENCES `admin` (`username`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
