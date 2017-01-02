-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 02 Oca 2017, 09:16:57
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

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `hastaneler`
--
ALTER TABLE `hastaneler`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `hastaneler`
--
ALTER TABLE `hastaneler`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
