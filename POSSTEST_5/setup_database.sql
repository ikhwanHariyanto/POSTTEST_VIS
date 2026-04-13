-- ============================================================
--   SETUP DATABASE: dbkamenrider
--   Jalankan script ini di phpMyAdmin atau MySQL Workbench
-- ============================================================

-- Buat database jika belum ada
CREATE DATABASE IF NOT EXISTS dbkamenrider
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_unicode_ci;

USE dbkamenrider;

-- Buat tabel koleksi
CREATE TABLE IF NOT EXISTS tbkoleksi (
    id          INT AUTO_INCREMENT PRIMARY KEY,
    nama_item   VARCHAR(150) NOT NULL,
    seri        VARCHAR(100) NOT NULL,
    tipe        VARCHAR(50)  NOT NULL,
    harga       BIGINT       NOT NULL DEFAULT 0,
    kondisi     VARCHAR(20)  NOT NULL DEFAULT 'Baru',
    status      VARCHAR(30)  NOT NULL DEFAULT 'Dimiliki',
    tahun_rilis INT          NOT NULL DEFAULT 2000,
    deskripsi   TEXT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Insert data contoh (opsional, hapus jika tidak mau data awal)
INSERT INTO tbkoleksi (nama_item, seri, tipe, harga, kondisi, status, tahun_rilis, deskripsi) VALUES
('DX Faiz Driver',          'Kamen Rider 555',       'Belt',      450000, 'Bekas', 'Dimiliki', 2003, 'Belt ikonik milik Kamen Rider Faiz/555. Dilengkapi dengan Mission Memory slot.'),
('DX Decade Driver',        'Kamen Rider Decade',    'Belt',      650000, 'Baru',  'Dimiliki', 2009, 'Belt utama Kamen Rider Decade yang bisa mengakses kekuatan Rider lain melalui Kamen Ride Card.'),
('DX Fourze Driver',        'Kamen Rider Fourze',    'Belt',      380000, 'Bekas', 'Dimiliki', 2011, 'Belt berbentuk roket dengan slot Astroswitch untuk berbagai modul.'),
('DX Sengoku Driver (Ryoma)','Kamen Rider Gaim',     'Belt',      720000, 'Baru',  'Wishlist', 2013, 'Sengoku Driver milik Kamen Rider Duke/Ryoma. Menggunakan Energy Lockseed.'),
('DX Ghost Driver',         'Kamen Rider Ghost',     'Belt',      490000, 'Bekas', 'Dimiliki', 2015, 'Belt utama Ghost yang menggunakan Ghost Eyecon untuk transform.'),
('DX Ex-Aid Gamer Driver',  'Kamen Rider Ex-Aid',    'Belt',      510000, 'Baru',  'Dimiliki', 2016, 'Gamer Driver milik Ex-Aid yang menggunakan Gashat untuk berubah.'),
('DX ZI-O Ride Watch (OOO)','Kamen Rider Zi-O',      'Ride Watch',220000, 'Baru',  'Wishlist', 2019, 'Ride Watch OOO yang digunakan Zi-O untuk mengakses kekuatan Kamen Rider OOO.'),
('DX Zero-One Driver',      'Kamen Rider Zero-One',  'Belt',      890000, 'Baru',  'Dimiliki', 2019, 'Belt terbaru dari era Reiwa pertama milik Aruto Hiden. Menggunakan Progrise Key.'),
('DX Saber Seiken (Rekka)', 'Kamen Rider Saber',     'Sword',     340000, 'Bekas', 'Dijual',   2020, 'Rekka no Ken, senjata utama Kamen Rider Saber yang menggunakan Wonder Ride Book.'),
('DX Revice Driver',        'Kamen Rider Revice',    'Belt',      760000, 'Baru',  'Dimiliki', 2021, 'Belt unik yang digunakan bersama oleh Ikki (Revi) dan Vice secara bersamaan.');
