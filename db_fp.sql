-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 26 Des 2019 pada 00.58
-- Versi server: 10.4.8-MariaDB
-- Versi PHP: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_fp`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_admin`
--

CREATE TABLE `tb_admin` (
  `id_admin` char(5) NOT NULL,
  `nama_admin` varchar(50) NOT NULL,
  `password` varchar(20) NOT NULL,
  `email` varchar(30) NOT NULL,
  `status_admin` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_admin`
--

INSERT INTO `tb_admin` (`id_admin`, `nama_admin`, `password`, `email`, `status_admin`) VALUES
('AD001', 'Budi Setiawan', 'Budi123', 'Budi.S@gmail.com', 0),
('AD002', 'Santi Rahayu', 'Santi_Imoetz', 'Santi1969@gmail.com', 0),
('AD003', 'Agus Sedunia', 'Agus123', 'Agus999@gmail.com', 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_barang`
--

CREATE TABLE `tb_barang` (
  `id_barang` char(5) NOT NULL,
  `id_ruang` char(5) DEFAULT NULL,
  `jenis_barang` varchar(30) NOT NULL,
  `nama_barang` varchar(30) NOT NULL,
  `status` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_barang`
--

INSERT INTO `tb_barang` (`id_barang`, `id_ruang`, `jenis_barang`, `nama_barang`, `status`) VALUES
('BR001', 'RU001', 'Identitas', 'KTP', 'Belum Diambil'),
('BR002', NULL, 'Surat', 'KK', 'Pelaporan'),
('BR003', 'RU003', 'Surat', 'Sertifikat - Budi Pahing', 'Diambil'),
('BR004', 'RU004', 'Perhiasan', 'Anting Emas 10gr', 'Diambil');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_lokasi`
--

CREATE TABLE `tb_lokasi` (
  `id_lokasi` char(5) NOT NULL,
  `nama_sector` varchar(20) NOT NULL,
  `lantai` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_lokasi`
--

INSERT INTO `tb_lokasi` (`id_lokasi`, `nama_sector`, `lantai`) VALUES
('LC001', 'Basement B', 2),
('LC002', 'Gedung A', 3),
('LC003', 'Gedung A', 5),
('LC004', 'Gedung B', 2);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_pelapor`
--

CREATE TABLE `tb_pelapor` (
  `id_pelapor` char(5) NOT NULL,
  `id_barang` char(5) NOT NULL,
  `nama_pelapor` varchar(50) DEFAULT NULL,
  `no_telp` varchar(20) NOT NULL,
  `id_lokasi` char(5) NOT NULL,
  `id_admin` char(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_pelapor`
--

INSERT INTO `tb_pelapor` (`id_pelapor`, `id_barang`, `nama_pelapor`, `no_telp`, `id_lokasi`, `id_admin`) VALUES
('PL001', 'BR002', 'Budi Setiawan', '085713355805', 'LC002', 'AD003'),
('PL002', 'BR004', 'Ucok Baba', '0871457845125', 'LC004', 'AD003'),
('PL003', 'BR003', 'Ahmad', '4548745115647', 'LC003', 'AD003');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_penemu`
--

CREATE TABLE `tb_penemu` (
  `id_penemu` char(5) NOT NULL,
  `id_barang` char(5) NOT NULL,
  `nama_penemu` varchar(50) NOT NULL,
  `id_lokasi` char(5) NOT NULL,
  `id_admin` char(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_penemu`
--

INSERT INTO `tb_penemu` (`id_penemu`, `id_barang`, `nama_penemu`, `id_lokasi`, `id_admin`) VALUES
('PN001', 'BR001', 'Budi Rahmat', 'LC001', 'AD003'),
('PN002', 'BR003', 'Ikhwan Setiaji', 'LC003', 'AD003'),
('PN003', 'BR004', 'Putri', 'LC004', 'AD003');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_ruang`
--

CREATE TABLE `tb_ruang` (
  `id_ruang` char(5) NOT NULL,
  `nama_ruang` varchar(10) DEFAULT NULL,
  `status_ruang` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_ruang`
--

INSERT INTO `tb_ruang` (`id_ruang`, `nama_ruang`, `status_ruang`) VALUES
('RU001', 'Rak 1.1', 'Ada'),
('RU002', 'Rak 1.2', 'Kosong'),
('RU003', 'Rak 1.3', 'Kosong'),
('RU004', 'Rak 1.4', 'Kosong'),
('RU005', 'Rak 2.1', 'Kosong'),
('RU006', 'Rak 2.2', 'Kosong'),
('RU007', 'Rak 2.3', 'Kosong'),
('RU008', 'Rak 2.4', 'Kosong'),
('RU009', 'Rak 3.1', 'Kosong');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tb_admin`
--
ALTER TABLE `tb_admin`
  ADD PRIMARY KEY (`id_admin`);

--
-- Indeks untuk tabel `tb_barang`
--
ALTER TABLE `tb_barang`
  ADD PRIMARY KEY (`id_barang`),
  ADD KEY `id_ruang` (`id_ruang`);

--
-- Indeks untuk tabel `tb_lokasi`
--
ALTER TABLE `tb_lokasi`
  ADD PRIMARY KEY (`id_lokasi`);

--
-- Indeks untuk tabel `tb_pelapor`
--
ALTER TABLE `tb_pelapor`
  ADD PRIMARY KEY (`id_pelapor`),
  ADD KEY `id_barang` (`id_barang`),
  ADD KEY `id_lokasi` (`id_lokasi`),
  ADD KEY `id_admin` (`id_admin`);

--
-- Indeks untuk tabel `tb_penemu`
--
ALTER TABLE `tb_penemu`
  ADD PRIMARY KEY (`id_penemu`),
  ADD KEY `id_barang` (`id_barang`),
  ADD KEY `id_lokasi` (`id_lokasi`),
  ADD KEY `id_admin` (`id_admin`);

--
-- Indeks untuk tabel `tb_ruang`
--
ALTER TABLE `tb_ruang`
  ADD PRIMARY KEY (`id_ruang`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tb_barang`
--
ALTER TABLE `tb_barang`
  ADD CONSTRAINT `tb_barang_ibfk_1` FOREIGN KEY (`id_ruang`) REFERENCES `tb_ruang` (`id_ruang`);

--
-- Ketidakleluasaan untuk tabel `tb_pelapor`
--
ALTER TABLE `tb_pelapor`
  ADD CONSTRAINT `tb_pelapor_ibfk_1` FOREIGN KEY (`id_barang`) REFERENCES `tb_barang` (`id_barang`),
  ADD CONSTRAINT `tb_pelapor_ibfk_2` FOREIGN KEY (`id_lokasi`) REFERENCES `tb_lokasi` (`id_lokasi`),
  ADD CONSTRAINT `tb_pelapor_ibfk_3` FOREIGN KEY (`id_admin`) REFERENCES `tb_admin` (`id_admin`);

--
-- Ketidakleluasaan untuk tabel `tb_penemu`
--
ALTER TABLE `tb_penemu`
  ADD CONSTRAINT `tb_penemu_ibfk_1` FOREIGN KEY (`id_barang`) REFERENCES `tb_barang` (`id_barang`),
  ADD CONSTRAINT `tb_penemu_ibfk_2` FOREIGN KEY (`id_lokasi`) REFERENCES `tb_lokasi` (`id_lokasi`),
  ADD CONSTRAINT `tb_penemu_ibfk_3` FOREIGN KEY (`id_admin`) REFERENCES `tb_admin` (`id_admin`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
