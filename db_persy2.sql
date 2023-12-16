-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 15 Des 2023 pada 08.57
-- Versi server: 10.4.28-MariaDB
-- Versi PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_persy2`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_detailtransaksi`
--

CREATE TABLE `tbl_detailtransaksi` (
  `id_detail` int(11) NOT NULL,
  `no_invoice` varchar(50) DEFAULT NULL,
  `id_produk` varchar(50) DEFAULT NULL,
  `jumlah` int(11) DEFAULT NULL,
  `subtotal` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_detailtransaksi`
--

INSERT INTO `tbl_detailtransaksi` (`id_detail`, `no_invoice`, `id_produk`, `jumlah`, `subtotal`) VALUES
(28, 'INV/001/12/2023', 'CP001', 1, 33000),
(29, 'INV/002/12/2023', 'CP001', 1, 33000),
(30, 'INV/006/12/2023', 'CP001', 1, 33000),
(31, 'INV/007/12/2023', 'CP001', 1, 33000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_produk`
--

CREATE TABLE `tbl_produk` (
  `id_produk` varchar(50) NOT NULL,
  `nama_produk` varchar(50) DEFAULT NULL,
  `harga` int(11) DEFAULT NULL,
  `stock` int(11) DEFAULT NULL,
  `kategori` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_produk`
--

INSERT INTO `tbl_produk` (`id_produk`, `nama_produk`, `harga`, `stock`, `kategori`) VALUES
('CP001', 'Sekar Jagat', 33000, 10, 'Car Parfume'),
('CP002', 'Sido Asih', 40000, 10, 'Car Parfume'),
('HP001', 'Sekar Jagat', 33000, 10, 'Homer Diffuser'),
('HP002', 'Sido Asih', 33000, 10, 'Homer Diffuser'),
('PP001', 'Anjani', 33000, 20, 'Personality Parfume');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_transaksi`
--

CREATE TABLE `tbl_transaksi` (
  `no_invoice` varchar(50) NOT NULL,
  `nama_pembeli` varchar(100) DEFAULT NULL,
  `total` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_transaksi`
--

INSERT INTO `tbl_transaksi` (`no_invoice`, `nama_pembeli`, `total`) VALUES
('INV/001/12/2023', 'Op', 66000),
('INV/002/12/2023', 'sari', 66000),
('INV/003/12/2023', 'Ste', 132000),
('INV/004/12/2023', 'dis', 66000),
('INV/005/12/2023', 'ri', 66000),
('INV/006/12/2023', 'rahmat', 66000),
('INV/007/12/2023', 'ye', 219000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_user`
--

CREATE TABLE `tbl_user` (
  `id_user` varchar(10) NOT NULL,
  `username` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `user_password` varchar(50) NOT NULL,
  `role` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_user`
--

INSERT INTO `tbl_user` (`id_user`, `username`, `email`, `user_password`, `role`) VALUES
('ADM001', 'Dimas Admin', 'admin@gmail.com', 'admin', 'Admin'),
('ADM002', 'Dimas Irmansyah', 'dimas@gmail.com', 'dimas1', 'Admin'),
('CSR001', 'Kasir', 'kasir@gmail.com', 'kasir', 'Kasir'),
('OWN001', 'Dimas Irmannsyah', 'dummyowner@gmail.com', 'owner', 'Owner'),
('OWN002', 'Dimas Firmansyah', 'dimas@gmail.com', 'dimas1', 'Owner');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbl_detailtransaksi`
--
ALTER TABLE `tbl_detailtransaksi`
  ADD PRIMARY KEY (`id_detail`),
  ADD KEY `no_invoice` (`no_invoice`),
  ADD KEY `id_produk` (`id_produk`);

--
-- Indeks untuk tabel `tbl_produk`
--
ALTER TABLE `tbl_produk`
  ADD PRIMARY KEY (`id_produk`);

--
-- Indeks untuk tabel `tbl_transaksi`
--
ALTER TABLE `tbl_transaksi`
  ADD PRIMARY KEY (`no_invoice`);

--
-- Indeks untuk tabel `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tbl_detailtransaksi`
--
ALTER TABLE `tbl_detailtransaksi`
  MODIFY `id_detail` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tbl_detailtransaksi`
--
ALTER TABLE `tbl_detailtransaksi`
  ADD CONSTRAINT `tbl_detailtransaksi_ibfk_1` FOREIGN KEY (`no_invoice`) REFERENCES `tbl_transaksi` (`no_invoice`),
  ADD CONSTRAINT `tbl_detailtransaksi_ibfk_2` FOREIGN KEY (`id_produk`) REFERENCES `tbl_produk` (`id_produk`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
