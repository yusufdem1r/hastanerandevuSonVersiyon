-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 02 Oca 2017, 09:17:04
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
-- Tablo için indeksler `uyeler`
--
ALTER TABLE `uyeler`
  ADD PRIMARY KEY (`tc`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
