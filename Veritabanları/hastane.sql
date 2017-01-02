-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 02 Oca 2017, 09:17:14
-- Sunucu sürümü: 10.1.16-MariaDB
-- PHP Sürümü: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `hastane`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `giris`
--

CREATE TABLE `giris` (
  `id` int(11) NOT NULL,
  `tc` varchar(20) NOT NULL,
  `gTarih` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `giris`
--

INSERT INTO `giris` (`id`, `tc`, `gTarih`) VALUES
(1, '123', '2017-01-02 04:41:11'),
(2, '123', '2017-01-02 04:41:11'),
(3, '123', '2017-01-02 04:41:11'),
(4, '123', '2017-01-02 04:41:11'),
(5, '123', '2017-01-02 04:41:11'),
(6, '2147483647', '2017-01-02 04:41:11'),
(7, '0', '2017-01-02 04:41:11'),
(8, '2147483647', '2017-01-02 04:41:11'),
(9, '2147483647', '2017-01-02 04:41:11'),
(10, '12345', '2017-01-02 04:41:11'),
(11, '2147483647', '2017-01-02 04:41:11'),
(12, '123456987', '2017-01-02 04:41:11'),
(13, '0', '2017-01-02 04:41:11'),
(14, '2147483647', '2017-01-02 04:41:11'),
(15, '2147483647', '2017-01-02 04:41:11'),
(16, '2147483647', '2017-01-02 04:41:11'),
(17, '18593262286', '2017-01-02 04:41:11'),
(18, '18593262286', '2017-01-02 04:41:11'),
(19, '18593262286', '2017-01-02 04:41:11'),
(20, '18593262286', '2017-01-02 04:41:11'),
(21, '18593262286', '2017-01-02 04:41:11'),
(22, '18593262286', '2017-01-02 04:41:11'),
(23, '123', '2017-01-02 04:41:11'),
(24, '18593262286', '2017-01-02 04:41:11'),
(25, '123', '2017-01-02 04:41:11'),
(26, '18593262286', '2017-01-02 04:41:11'),
(27, '18593262286', '2017-01-02 04:41:11'),
(28, '18593262286', '2017-01-02 04:41:11'),
(29, '18593262286', '2017-01-02 04:41:11'),
(30, '123', '2017-01-02 04:41:11'),
(31, '123456987', '2017-01-02 04:41:11'),
(32, '18593262286', '2017-01-02 04:41:11'),
(33, '18593262286', '2017-01-02 04:41:11'),
(34, '123', '2017-01-02 04:41:11'),
(35, '18593262286', '2017-01-02 04:41:11'),
(36, '18593262286', '2017-01-02 04:43:10'),
(37, '18593262286', '2017-01-02 04:54:05'),
(38, '18593262286', '2017-01-02 04:55:41'),
(39, '18593262286', '2017-01-02 05:13:05'),
(40, '18593262286', '2017-01-02 05:14:36'),
(41, '18593262286', '2017-01-02 05:16:55'),
(42, '18593262286', '2017-01-02 05:21:38'),
(43, '123', '2017-01-02 05:22:58'),
(44, '123', '2017-01-02 05:30:18'),
(45, '123', '2017-01-02 05:33:19'),
(46, '123', '2017-01-02 05:38:58'),
(47, '123', '2017-01-02 05:39:02'),
(48, '123', '2017-01-02 05:46:02'),
(49, '123', '2017-01-02 05:46:04'),
(50, '123', '2017-01-02 05:47:19'),
(51, '123', '2017-01-02 05:48:09'),
(52, '18593262286', '2017-01-02 05:49:42'),
(53, '18593262286', '2017-01-02 05:59:38'),
(54, '66997227424', '2017-01-02 06:08:52'),
(55, '18593262286', '2017-01-02 06:27:23'),
(56, '18593262286', '2017-01-02 06:29:01'),
(57, '18593262286', '2017-01-02 06:30:21'),
(58, '18593262286', '2017-01-02 06:31:05'),
(59, '18593262286', '2017-01-02 06:33:42'),
(60, '18593262286', '2017-01-02 06:39:53'),
(61, '123', '2017-01-02 06:42:01'),
(62, '123', '2017-01-02 06:42:19'),
(63, '123', '2017-01-02 06:43:43'),
(64, '123', '2017-01-02 06:46:00'),
(65, '123', '2017-01-02 06:46:31'),
(66, '123', '2017-01-02 06:48:36'),
(67, '18593262286', '2017-01-02 06:52:06'),
(68, '123', '2017-01-02 07:07:02'),
(69, 'admin', '2017-01-02 07:11:54'),
(70, '123', '2017-01-02 07:29:34'),
(71, '123', '2017-01-02 07:31:04'),
(72, '123', '2017-01-02 07:31:38'),
(73, '123', '2017-01-02 07:32:57'),
(74, '123', '2017-01-02 07:33:54'),
(75, '123', '2017-01-02 07:34:43'),
(76, '123', '2017-01-02 07:37:00'),
(77, 'admin', '2017-01-02 07:44:11'),
(78, 'admin', '2017-01-02 07:44:54'),
(79, 'admin', '2017-01-02 07:49:57'),
(80, 'admin', '2017-01-02 07:51:04'),
(81, 'admin', '2017-01-02 07:53:57'),
(82, 'admin', '2017-01-02 08:02:07'),
(83, 'admin', '2017-01-02 08:03:29'),
(84, 'admin', '2017-01-02 08:04:56'),
(85, 'admin', '2017-01-02 08:07:07'),
(86, 'admin', '2017-01-02 08:10:36'),
(87, 'admin', '2017-01-02 08:11:38'),
(88, '111111', '2017-01-02 08:12:55'),
(89, 'admin', '2017-01-02 08:13:55'),
(90, '321', '2017-01-02 08:15:05'),
(91, 'admin', '2017-01-02 08:15:36');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `hastaneler`
--

CREATE TABLE `hastaneler` (
  `id` int(11) NOT NULL,
  `tc` varchar(20) NOT NULL,
  `hastaneAd` varchar(30) NOT NULL,
  `klinikAd` varchar(30) NOT NULL,
  `doktorAd` varchar(30) NOT NULL,
  `tarih` varchar(30) NOT NULL,
  `saat` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `hastaneler`
--

INSERT INTO `hastaneler` (`id`, `tc`, `hastaneAd`, `klinikAd`, `doktorAd`, `tarih`, `saat`) VALUES
(2, '18593262286', 'Eyüp Devlet', 'Cildiye', 'Melih Süzer', '22.01.2017', '17:00'),
(3, '18593262286', 'Taksim Ilkyardim Hastanesi', 'Enfeksiyon', 'Tugba Laçin', '29.01.2017', '13:00'),
(4, '66997227424', 'Eyüp Devlet', 'Dahiliye', 'Yusuf Demir', '13.01.2017', '16:00'),
(5, '66997227424', 'Eyüp Devlet', 'Dahiliye', 'Yusuf Demir', '13.01.2017', '18:00'),
(9, '111111', 'Eyüp Devlet', 'Genel Cerrahi', 'Yusuf Demir', '22.01.2017', '12:00');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `uyeler`
--

CREATE TABLE `uyeler` (
  `tc` varchar(20) NOT NULL,
  `ad` varchar(20) NOT NULL,
  `soyad` varchar(30) NOT NULL,
  `cinsiyet` varchar(5) NOT NULL,
  `dYeri` varchar(20) NOT NULL,
  `dTarihi` text NOT NULL,
  `babaad` varchar(20) NOT NULL,
  `annead` varchar(20) NOT NULL,
  `eposta` varchar(30) NOT NULL,
  `sifre` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `uyeler`
--

INSERT INTO `uyeler` (`tc`, `ad`, `soyad`, `cinsiyet`, `dYeri`, `dTarihi`, `babaad`, `annead`, `eposta`, `sifre`) VALUES
('111111', 'dddddd', 'yyyyy', 'Erkek', 'cccccccccc', '12.01.2017', 'eeeeeeeeee', 'wwwwwww', 'qqqqqqqqqqqq', '123'),
('123', 'kemal', 'demirr12', '', 'dasdsa', '15.01.2017', 'alican', 'fatma', 'can@hotmail.com', '33'),
('123456789', 'veli', 'bakkal', 'Erkek', 'samsun', '7.01.2017', 'sukru', 'naciye', 'dostum@hotmail.com', '852000'),
('123456987', 'hakan', 'aslan', 'Erkek', 'karabuk', '12.01.2017', 'emre', 'cansu', 'dasdsa@hotmail.com', '147'),
('18593262286', 'yusuf', 'demir', 'Erkek', 'bakirköy', '7.01.1997', 'mustafa', 'ayse', 'yusufomg34@gmail.com', '78451200'),
('321', 'dsadsad', 'dsadsa', 'Kiz', 'dasdadsa', '22.01.2017', 'dsadsa', 'dsadsa', 'dsadsa', '123'),
('66997227424', 'ezgi', 'usta', 'Kiz', 'ankara', '6.02.1997', 'asda', 'sdads', 'asds', '12345');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `giris`
--
ALTER TABLE `giris`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `hastaneler`
--
ALTER TABLE `hastaneler`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `uyeler`
--
ALTER TABLE `uyeler`
  ADD PRIMARY KEY (`tc`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `giris`
--
ALTER TABLE `giris`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=92;
--
-- Tablo için AUTO_INCREMENT değeri `hastaneler`
--
ALTER TABLE `hastaneler`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
