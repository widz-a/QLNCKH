/* =========================
   TẠO DATABASE
   ========================= */
CREATE DATABASE QLNCKH;
GO
USE QLNCKH;
GO

/* =========================
   DANH MỤC ĐỊA LÝ
   ========================= */
CREATE TABLE Tinh (
    TinhId INT PRIMARY KEY,
    TenTinh NVARCHAR(100) NOT NULL
);
GO

INSERT INTO Tinh (TinhId, TenTinh) VALUES 
(1, N'Thành phố Hà Nội'),
(4, N'Tỉnh Cao Bằng'),
(8, N'Tỉnh Tuyên Quang'),
(11, N'Tỉnh Điện Biên'),
(12, N'Tỉnh Lai Châu'),
(14, N'Tỉnh Sơn La'),
(15, N'Tỉnh Lào Cai'),
(19, N'Tỉnh Thái Nguyên'),
(20, N'Tỉnh Lạng Sơn'),
(22, N'Tỉnh Quảng Ninh'),
(24, N'Tỉnh Bắc Ninh'),
(25, N'Tỉnh Phú Thọ'),
(31, N'Thành phố Hải Phòng'),
(33, N'Tỉnh Hưng Yên'),
(37, N'Tỉnh Ninh Bình'),
(38, N'Tỉnh Thanh Hóa'),
(40, N'Tỉnh Nghệ An'),
(42, N'Tỉnh Hà Tĩnh'),
(44, N'Tỉnh Quảng Trị'),
(46, N'Thành phố Huế'),
(48, N'Thành phố Đà Nẵng'),
(51, N'Tỉnh Quảng Ngãi'),
(52, N'Tỉnh Gia Lai'),
(56, N'Tỉnh Khánh Hòa'),
(66, N'Tỉnh Đắk Lắk'),
(68, N'Tỉnh Lâm Đồng'),
(75, N'Tỉnh Đồng Nai'),
(79, N'Thành phố Hồ Chí Minh'),
(80, N'Tỉnh Tây Ninh'),
(82, N'Tỉnh Đồng Tháp'),
(86, N'Tỉnh Vĩnh Long'),
(91, N'Tỉnh An Giang'),
(92, N'Thành phố Cần Thơ'),
(96, N'Tỉnh Cà Mau');
GO

CREATE TABLE Xa (
    XaId INT PRIMARY KEY,
    TenXa NVARCHAR(100),
    TinhId INT NOT NULL,
    FOREIGN KEY (TinhId) REFERENCES Tinh(TinhId)
);
GO
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4, N'Phường Ba Đình', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8, N'Phường Ngọc Hà', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25, N'Phường Giảng Võ', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (70, N'Phường Hoàn Kiếm', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (82, N'Phường Cửa Nam', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (91, N'Phường Phú Thượng', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (97, N'Phường Hồng Hà', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (103, N'Phường Tây Hồ', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (118, N'Phường Bồ Đề', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (127, N'Phường Việt Hưng', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (136, N'Phường Phúc Lợi', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (145, N'Phường Long Biên', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (160, N'Phường Nghĩa Đô', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (166, N'Phường Cầu Giấy', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (175, N'Phường Yên Hòa', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (190, N'Phường Ô Chợ Dừa', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (199, N'Phường Láng', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (226, N'Phường Văn Miếu - Quốc Tử Giám', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (229, N'Phường Kim Liên', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (235, N'Phường Đống Đa', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (256, N'Phường Hai Bà Trưng', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (283, N'Phường Vĩnh Tuy', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (292, N'Phường Bạch Mai', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (301, N'Phường Vĩnh Hưng', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (316, N'Phường Định Công', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (322, N'Phường Tương Mai', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (328, N'Phường Lĩnh Nam', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (331, N'Phường Hoàng Mai', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (337, N'Phường Hoàng Liệt', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (340, N'Phường Yên Sở', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (352, N'Phường Phương Liệt', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (364, N'Phường Khương Đình', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (367, N'Phường Thanh Xuân', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (376, N'Xã Sóc Sơn', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (382, N'Xã Kim Anh', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (385, N'Xã Trung Giã ', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (430, N'Xã Đa Phúc', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (433, N'Xã Nội Bài', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (454, N'Xã Đông Anh', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (466, N'Xã Phúc Thịnh', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (475, N'Xã Thư Lâm', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (493, N'Xã Thiên Lộc', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (508, N'Xã Vĩnh Thanh', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (541, N'Xã Phù Đổng', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (562, N'Xã Thuận An', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (565, N'Xã Gia Lâm', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (577, N'Xã Bát Tràng', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (592, N'Phường Từ Liêm', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (598, N'Phường Thượng Cát', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (602, N'Phường Đông Ngạc', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (611, N'Phường Xuân Đỉnh', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (613, N'Phường Tây Tựu', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (619, N'Phường Phú Diễn', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (622, N'Phường Xuân Phương ', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (634, N'Phường Tây Mỗ', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (637, N'Phường Đại Mỗ', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (640, N'Xã Thanh Trì', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (643, N'Phường Thanh Liệt', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (664, N'Xã Đại Thanh', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (679, N'Xã Ngọc Hồi', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (685, N'Xã Nam Phù', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4930, N'Xã Yên Xuân', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8974, N'Xã Quang Minh', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8980, N'Xã Yên Lãng', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8995, N'Xã Tiến Thắng', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9022, N'Xã Mê Linh', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9552, N'Phường Kiến Hưng ', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9556, N'Phường Hà Đông', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9562, N'Phường Yên Nghĩa', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9568, N'Phường Phú Lương', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9574, N'Phường Sơn Tây', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9604, N'Phường Tùng Thiện', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9616, N'Xã Đoài Phương', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9619, N'Xã Quảng Oai', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9634, N'Xã Cổ Đô', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9661, N'Xã Minh Châu', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9664, N'Xã Vật Lại', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9676, N'Xã Bất Bạt', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9694, N'Xã Suối Hai', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9700, N'Xã Ba Vì', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9706, N'Xã Yên Bài ', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9715, N'Xã Phúc Thọ', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9739, N'Xã Phúc Lộc', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9772, N'Xã Hát Môn', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9784, N'Xã Đan Phượng', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9787, N'Xã Liên Minh', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9817, N'Xã Ô Diên', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9832, N'Xã Hoài Đức', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9856, N'Xã Dương Hòa', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9871, N'Xã Sơn Đồng', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9877, N'Xã An Khánh', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9886, N'Phường Dương Nội', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9895, N'Xã Quốc Oai', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9910, N'Xã Kiều Phú', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9931, N'Xã Hưng Đạo ', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9952, N'Xã Phú Cát ', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9955, N'Xã Thạch Thất', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9982, N'Xã Hạ Bằng', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9988, N'Xã Hòa Lạc', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10003, N'Xã Tây Phương', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10015, N'Phường Chương Mỹ', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10030, N'Xã Phú Nghĩa', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10045, N'Xã Xuân Mai', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10072, N'Xã Quảng Bị', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10081, N'Xã Trần Phú ', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10096, N'Xã Hòa Phú ', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10114, N'Xã Thanh Oai', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10126, N'Xã Bình Minh ', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10144, N'Xã Tam Hưng', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10180, N'Xã Dân Hòa ', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10183, N'Xã Thường Tín', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10210, N'Xã Hồng Vân', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10231, N'Xã Thượng Phúc', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10237, N'Xã Chương Dương', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10273, N'Xã Phú Xuyên', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10279, N'Xã Phượng Dực', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10330, N'Xã Chuyên Mỹ', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10342, N'Xã Đại Xuyên', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10354, N'Xã Vân Đình', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10369, N'Xã Ứng Thiên', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10402, N'Xã Ứng Hòa', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10417, N'Xã Hòa Xá', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10441, N'Xã Mỹ Đức', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10459, N'Xã Phúc Sơn', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10465, N'Xã Hồng Sơn', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10489, N'Xã Hương Sơn', 1);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1273, N'Phường Thục Phán', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1279, N'Phường Nùng Trí Cao', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1288, N'Phường Tân Giang', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1290, N'Xã Bảo Lâm', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1294, N'Xã Lý Bôn', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1297, N'Xã Nam Quang', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1304, N'Xã Quảng Lâm', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1318, N'Xã Yên Thổ', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1321, N'Xã Bảo Lạc', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1324, N'Xã Cốc Pàng', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1327, N'Xã Cô Ba', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1336, N'Xã Khánh Xuân', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1339, N'Xã Xuân Trường', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1351, N'Xã Hưng Đạo', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1354, N'Xã Huy Giáp', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1360, N'Xã Sơn Lộ', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1363, N'Xã Thông Nông', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1366, N'Xã Cần Yên', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1387, N'Xã Thanh Long', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1392, N'Xã Trường Hà', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1393, N'Xã Lũng Nặm', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1414, N'Xã Tổng Cọt', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1438, N'Xã Hà Quảng', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1447, N'Xã Trà Lĩnh', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1456, N'Xã Quang Hán', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1465, N'Xã Quang Trung', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1477, N'Xã Trùng Khánh', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1489, N'Xã Đình Phong', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1501, N'Xã Đàm Thủy', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1525, N'Xã Đoài Dương', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1537, N'Xã Lý Quốc', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1552, N'Xã Quang Long', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1558, N'Xã Hạ Lang', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1561, N'Xã Vinh Quý', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1576, N'Xã Quảng Uyên', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1594, N'Xã Độc Lập', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1618, N'Xã Hạnh Phúc', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1636, N'Xã Bế Văn Đàn', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1648, N'Xã Phục Hòa', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1654, N'Xã Hòa An', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1660, N'Xã Nam Tuấn', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1699, N'Xã Nguyễn Huệ', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1708, N'Xã Bạch Đằng', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1726, N'Xã Nguyên Bình', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1729, N'Xã Tĩnh Túc', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1738, N'Xã Ca Thành', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1747, N'Xã Minh Tâm', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1768, N'Xã Phan Thanh', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1774, N'Xã Tam Kim', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1777, N'Xã Thành Công', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1786, N'Xã Đông Khê', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1789, N'Xã Canh Tân', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1792, N'Xã Kim Đồng', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1795, N'Xã Minh Khai', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1807, N'Xã Thạch An', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1822, N'Xã Đức Long', 4);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (691, N'Phường Hà Giang 2', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (694, N'Phường Hà Giang 1', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (700, N'Xã Ngọc Đường', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (706, N'Xã Phú Linh', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (715, N'Xã Lũng Cú', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (721, N'Xã Đồng Văn', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (733, N'Xã Sà Phìn ', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (745, N'Xã Phố Bảng', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (763, N'Xã Lũng Phìn', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (769, N'Xã Mèo Vạc', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (778, N'Xã Sơn Vĩ', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (787, N'Xã Sủng Máng', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (802, N'Xã Khâu Vai', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (808, N'Xã Tát Ngà', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (817, N'Xã Niêm Sơn', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (820, N'Xã Yên Minh', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (829, N'Xã Thắng Mố', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (832, N'Xã Bạch Đích', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (847, N'Xã Mậu Duệ', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (859, N'Xã Ngọc Long', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (865, N'Xã Đường Thượng', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (871, N'Xã Du Già', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (874, N'Xã Quản Bạ', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (883, N'Xã Cán Tỷ', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (889, N'Xã Nghĩa Thuận', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (892, N'Xã Tùng Vài', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (901, N'Xã Lùng Tám', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (913, N'Xã Vị Xuyên', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (919, N'Xã Minh Tân', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (922, N'Xã Thuận Hoà', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (925, N'Xã Tùng Bá', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (928, N'Xã Thanh Thủy', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (937, N'Xã Lao Chải', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (952, N'Xã Cao Bồ', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (958, N'Xã Thượng Sơn', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (967, N'Xã Việt Lâm', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (970, N'Xã Linh Hồ', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (976, N'Xã Bạch Ngọc', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (982, N'Xã Minh Sơn', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (985, N'Xã Giáp Trung', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (991, N'Xã Bắc Mê', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (994, N'Xã Minh Ngọc', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1006, N'Xã Yên Cường', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1012, N'Xã Đường Hồng', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1021, N'Xã Hoàng Su Phì', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1024, N'Xã Bản Máy', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1033, N'Xã Thàng Tín', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1051, N'Xã Tân Tiến', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1057, N'Xã Pờ Ly Ngài', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1075, N'Xã Nậm Dịch', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1084, N'Xã Hồ Thầu', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1090, N'Xã Thông Nguyên', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1096, N'Xã Pà Vầy Sủ', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1108, N'Xã Xín Mần', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1117, N'Xã Trung Thịnh', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1141, N'Xã Nấm Dẩn', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1144, N'Xã Quảng Nguyên', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1147, N'Xã Khuôn Lùng', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1153, N'Xã Bắc Quang', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1156, N'Xã Vĩnh Tuy', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1165, N'Xã Đồng Tâm', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1171, N'Xã Tân Quang', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1180, N'Xã Bằng Hành', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1192, N'Xã Liên Hiệp', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1201, N'Xã Hùng An', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1216, N'Xã Đồng Yên', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1225, N'Xã Tiên Nguyên', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1234, N'Xã Yên Thành', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1237, N'Xã Quang Bình', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1243, N'Xã Tân Trịnh', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1246, N'Xã Bằng Lang', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1255, N'Xã Xuân Giang', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1261, N'Xã Tiên Yên', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2212, N'Phường Nông Tiến ', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2215, N'Phường Minh Xuân', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2221, N'Xã Nà Hang', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2239, N'Xã Thượng Nông', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2245, N'Xã Côn Lôn', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2248, N'Xã Yên Hoa', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2260, N'Xã Hồng Thái ', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2266, N'Xã Lâm Bình ', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2269, N'Xã Thượng Lâm', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2287, N'Xã Chiêm Hoá', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2296, N'Xã Bình An', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2302, N'Xã Minh Quang', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2305, N'Xã Trung Hà', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2308, N'Xã Tân Mỹ', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2317, N'Xã Yên Lập', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2320, N'Xã Tân An', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2332, N'Xã Kiên Đài', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2350, N'Xã Kim Bình', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2353, N'Xã Hoà An', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2359, N'Xã Tri Phú ', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2365, N'Xã Yên Nguyên', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2374, N'Xã Hàm Yên', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2380, N'Xã Bạch Xa', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2392, N'Xã Phù Lưu', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2398, N'Xã Yên Phú', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2404, N'Xã Bình Xa', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2407, N'Xã Thái Sơn', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2419, N'Xã Thái Hoà', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2425, N'Xã Hùng Đức', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2434, N'Xã Lực Hành', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2437, N'Xã Kiến Thiết', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2449, N'Xã Xuân Vân', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2455, N'Xã Hùng Lợi', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2458, N'Xã Trung Sơn', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2470, N'Xã Tân Long', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2473, N'Xã Yên Sơn', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2494, N'Xã Thái Bình', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2509, N'Phường Mỹ Lâm', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2512, N'Phường An Tường', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2524, N'Phường Bình Thuận ', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2530, N'Xã Nhữ Khê', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2536, N'Xã Sơn Dương', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2545, N'Xã Tân Trào', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2548, N'Xã Bình Ca', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2554, N'Xã Minh Thanh', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2572, N'Xã Đông Thọ', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2578, N'Xã Tân Thanh', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2608, N'Xã Hồng Sơn', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2611, N'Xã Phú Lương', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2620, N'Xã Sơn Thuỷ', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2623, N'Xã Trường Sinh', 8);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3127, N'Phường Điện Biên Phủ', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3151, N'Phường Mường Lay', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3158, N'Xã Sín Thầu', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3160, N'Xã Mường Nhé', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3162, N'Xã Nậm Kè', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3163, N'Xã Mường Toong', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3164, N'Xã Quảng Lâm', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3166, N'Xã Mường Chà', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3169, N'Xã Nà Hỳ', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3172, N'Xã Na Sang', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3175, N'Xã Chà Tở', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3176, N'Xã Nà Bủng', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3181, N'Xã Mường Tùng', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3193, N'Xã Pa Ham', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3194, N'Xã Nậm Nèn', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3199, N'Xã Si Pa Phìn', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3202, N'Xã Mường Pồn', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3203, N'Xã Na Son', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3208, N'Xã Xa Dung', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3214, N'Xã Mường Luân', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3217, N'Xã Tủa Chùa', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3220, N'Xã Tủa Thàng', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3226, N'Xã Sín Chải', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3241, N'Xã Sính Phình', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3244, N'Xã Sáng Nhè', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3253, N'Xã Tuần Giáo', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3256, N'Xã Mường Ảng', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3260, N'Xã Pú Nhung', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3268, N'Xã Mường Mùn', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3283, N'Xã Chiềng Sinh', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3295, N'Xã Quài Tở', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3301, N'Xã Búng Lao', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3313, N'Xã Mường Lạn', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3316, N'Xã Nà Tấu', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3325, N'Xã Mường Phăng', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3328, N'Xã Thanh Nưa', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3334, N'Phường Mường Thanh', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3349, N'Xã Thanh Yên', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3352, N'Xã Thanh An', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3356, N'Xã Sam Mứn', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3358, N'Xã Núa Ngam', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3368, N'Xã Mường Nhà', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3370, N'Xã Pu Nhi', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3382, N'Xã Phình Giàng', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3385, N'Xã Tìa Dình', 11);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3388, N'Phường Đoàn Kết', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3390, N'Xã Bình Lư', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3394, N'Xã Sin Suối Hồ', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3405, N'Xã Tả Lèng', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3408, N'Phường Tân Phong', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3424, N'Xã Bản Bo', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3430, N'Xã Khun Há', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3433, N'Xã Bum Tở', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3434, N'Xã Nậm Hàng', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3439, N'Xã Thu Lũm', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3442, N'Xã Pa Ủ', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3445, N'Xã Mường Tè', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3451, N'Xã Mù Cả', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3460, N'Xã Hua Bum', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3463, N'Xã Tà Tổng', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3466, N'Xã Bum Nưa', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3472, N'Xã Mường Mô', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3478, N'Xã Sìn Hồ', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3487, N'Xã Lê Lợi', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3503, N'Xã Pa Tần', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3508, N'Xã Hồng Thu', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3517, N'Xã Nậm Tăm', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3529, N'Xã Tủa Sín Chải', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3532, N'Xã Pu Sam Cáp', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3538, N'Xã Nậm Mạ', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3544, N'Xã Nậm Cuổi', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3549, N'Xã Phong Thổ', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3562, N'Xã Sì Lở Lầu', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3571, N'Xã Dào San', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3583, N'Xã Khổng Lào', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3595, N'Xã Than Uyên', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3598, N'Xã Tân Uyên', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3601, N'Xã Mường Khoa', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3613, N'Xã Nậm Sỏ', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3616, N'Xã Pắc Ta', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3618, N'Xã Mường Than', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3637, N'Xã Mường Kim', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3640, N'Xã Khoen On', 12);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3646, N'Phường Tô Hiệu', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3664, N'Phường Chiềng An', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3670, N'Phường Chiềng Cơi', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3679, N'Phường Chiềng Sinh', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3688, N'Xã Mường Chiên', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3694, N'Xã Mường Giôn', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3703, N'Xã Quỳnh Nhai', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3712, N'Xã Mường Sại', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3721, N'Xã Thuận Châu', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3724, N'Xã Bình Thuận', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3727, N'Xã Mường É', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3754, N'Xã Chiềng La', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3757, N'Xã Mường Khiêng', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3760, N'Xã Mường Bám', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3763, N'Xã Long Hẹ', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3781, N'Xã Co Mạ', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3784, N'Xã Nậm Lầu', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3799, N'Xã Muổi Nọi', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3808, N'Xã Mường La', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3814, N'Xã Chiềng Lao', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3820, N'Xã Ngọc Chiến', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3847, N'Xã Mường Bú', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3850, N'Xã Chiềng Hoa', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3856, N'Xã Bắc Yên', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3862, N'Xã Xím Vàng', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3868, N'Xã Tà Xùa', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3871, N'Xã Pắc Ngà', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3880, N'Xã Tạ Khoa', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3892, N'Xã Chiềng Sại', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3901, N'Xã Suối Tọ', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3907, N'Xã Mường Cơi', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3910, N'Xã Phù Yên', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3922, N'Xã Gia Phù', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3943, N'Xã Mường Bang', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3958, N'Xã Tường Hạ', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3961, N'Xã Kim Bon', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3970, N'Xã Tân Phong', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3979, N'Phường Mộc Sơn', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3980, N'Phường Mộc Châu', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3982, N'Phường Thảo Nguyên', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3985, N'Xã Chiềng Sơn', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3997, N'Xã Tân Yên', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4000, N'Xã Đoàn Kết', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4006, N'Xã Song Khủa', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4018, N'Xã Tô Múa', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4033, N'Phường Vân Sơn', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4045, N'Xã Lóng Sập', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4048, N'Xã Vân Hồ', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4057, N'Xã Xuân Nha', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4075, N'Xã Yên Châu', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4078, N'Xã Chiềng Hặc', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4087, N'Xã Yên Sơn', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4096, N'Xã Lóng Phiêng', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4099, N'Xã Phiêng Khoài', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4105, N'Xã Mai Sơn', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4108, N'Xã Chiềng Sung', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4117, N'Xã Mường Chanh', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4123, N'Xã Chiềng Mung', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4132, N'Xã Chiềng Mai', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4136, N'Xã Tà Hộc', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4144, N'Xã Phiêng Cằm', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4159, N'Xã Phiêng Pằn', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4168, N'Xã Sông Mã', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4171, N'Xã Bó Sinh', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4183, N'Xã Mường Lầm', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4186, N'Xã Nậm Ty', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4195, N'Xã Chiềng Sơ', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4204, N'Xã Chiềng Khoong', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4210, N'Xã Huổi Một', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4219, N'Xã Mường Hung', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4222, N'Xã Chiềng Khương', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4228, N'Xã Púng Bánh', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4231, N'Xã Sốp Cộp', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4240, N'Xã Mường Lèo', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4246, N'Xã Mường Lạn', 14);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2647, N'Phường Lào Cai', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2671, N'Phường Cam Đường', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2680, N'Xã Hợp Thành', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2683, N'Xã Bát Xát', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2686, N'Xã A Mú Sung', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2695, N'Xã Trịnh Tường', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2701, N'Xã Y Tý', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2707, N'Xã Dền Sáng', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2725, N'Xã Bản Xèo', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2728, N'Xã Mường Hum', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2746, N'Xã Cốc San', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2752, N'Xã Pha Long ', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2761, N'Xã Mường Khương', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2782, N'Xã Cao Sơn', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2788, N'Xã Bản Lầu', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2809, N'Xã Si Ma Cai', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2824, N'Xã Sín Chéng', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2839, N'Xã Bắc Hà', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2842, N'Xã Tả Củ Tỷ', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2848, N'Xã Lùng Phình', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2869, N'Xã Bản Liền', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2890, N'Xã Bảo Nhai', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2896, N'Xã Cốc Lầu', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2902, N'Xã Phong Hải', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2905, N'Xã Bảo Thắng', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2908, N'Xã Tằng Loỏng', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2923, N'Xã Gia Phú', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2926, N'Xã Xuân Quang', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2947, N'Xã Bảo Yên', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2953, N'Xã Nghĩa Đô', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2962, N'Xã Xuân Hòa', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2968, N'Xã Thượng Hà', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2989, N'Xã Bảo Hà', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2998, N'Xã Phúc Khánh', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3004, N'Xã Ngũ Chỉ Sơn', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3006, N'Phường Sa Pa', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3013, N'Xã Tả Phìn', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3037, N'Xã Tả Van', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3043, N'Xã Mường Bo', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3046, N'Xã Bản Hồ', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3061, N'Xã Võ Lao', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3076, N'Xã Nậm Chày', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3082, N'Xã Văn Bàn', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3085, N'Xã Nậm Xé', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3091, N'Xã Chiềng Ken ', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3103, N'Xã Khánh Yên', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3106, N'Xã Dương Quỳ', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (3121, N'Xã Minh Lương', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4252, N'Phường Yên Bái', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4273, N'Phường Nam Cường', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4279, N'Phường Văn Phú', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4288, N'Phường Nghĩa Lộ', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4303, N'Xã Lục Yên', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4309, N'Xã Lâm Thượng', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4336, N'Xã Tân Lĩnh', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4342, N'Xã Khánh Hòa', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4345, N'Xã Mường Lai', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4363, N'Xã Phúc Lợi', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4375, N'Xã Mậu A', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4381, N'Xã Lâm Giang', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4387, N'Xã Châu Quế', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4399, N'Xã Đông Cuông', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4402, N'Xã Phong Dụ Hạ', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4423, N'Xã Phong Dụ Thượng', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4429, N'Xã Tân Hợp', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4441, N'Xã Xuân Ái', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4450, N'Xã Mỏ Vàng', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4456, N'Xã Mù Cang Chải', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4462, N'Xã Nậm Có', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4465, N'Xã Khao Mang', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4474, N'Xã Lao Chải', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4489, N'Xã Chế Tạo', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4492, N'Xã Púng Luông', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4498, N'Xã Trấn Yên', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4531, N'Xã Quy Mông', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4537, N'Xã Lương Thịnh', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4543, N'Phường Âu Lâu', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4564, N'Xã Việt Hồng', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4576, N'Xã Hưng Khánh', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4585, N'Xã Hạnh Phúc', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4603, N'Xã Tà Xi Láng', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4606, N'Xã Trạm Tấu', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4609, N'Xã Phình Hồ', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4630, N'Xã Tú Lệ', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4636, N'Xã Gia Hội', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4651, N'Xã Sơn Lương', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4660, N'Xã Liên Sơn', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4663, N'Phường Trung Tâm', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4672, N'Xã Văn Chấn', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4681, N'Phường Cầu Thia', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4693, N'Xã Cát Thịnh', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4699, N'Xã Chấn Thịnh', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4705, N'Xã Thượng Bằng La', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4711, N'Xã Nghĩa Tâm', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4714, N'Xã Yên Bình', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4717, N'Xã Thác Bà', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4726, N'Xã Cảm Nhân', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4744, N'Xã Yên Thành', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4750, N'Xã Bảo Ái ', 15);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1840, N'Phường Đức Xuân', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1843, N'Phường Bắc Kạn', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1849, N'Xã Phong Quang', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1864, N'Xã Bằng Thành', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1879, N'Xã Cao Minh', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1882, N'Xã Nghiên Loan', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1894, N'Xã Phúc Lộc', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1906, N'Xã Ba Bể', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1912, N'Xã Chợ Rã', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1921, N'Xã Thượng Minh', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1933, N'Xã Đồng Phúc', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1936, N'Xã Nà Phặc', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1942, N'Xã Bằng Vân', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1954, N'Xã Ngân Sơn', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1957, N'Xã Thượng Quan', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1960, N'Xã Hiệp Lực', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1969, N'Xã Phủ Thông', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (1981, N'Xã Vĩnh Thông', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2008, N'Xã Cẩm Giàng', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2014, N'Xã Bạch Thông', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2020, N'Xã Chợ Đồn', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2026, N'Xã Nam Cường', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2038, N'Xã Quảng Bạch', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2044, N'Xã Yên Thịnh', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2071, N'Xã Nghĩa Tá', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2083, N'Xã Yên Phong', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2086, N'Xã Chợ Mới', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2101, N'Xã Thanh Mai', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2104, N'Xã Tân Kỳ', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2107, N'Xã Thanh Thịnh', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2116, N'Xã Yên Bình', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2143, N'Xã Văn Lang', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2152, N'Xã Cường Lợi', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2155, N'Xã Na Rì', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2176, N'Xã Trần Phú', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2185, N'Xã Côn Minh', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (2191, N'Xã Xuân Dương', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5443, N'Phường Phan Đình Phùng', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5455, N'Phường Quyết Thắng', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5467, N'Phường Gia Sàng', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5482, N'Phường Quan Triều', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5488, N'Xã Đại Phúc', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5500, N'Phường Tích Lương', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5503, N'Xã Tân Cương', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5518, N'Phường Sông Công', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5528, N'Phường Bách Quang', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5533, N'Phường Bá Xuyên', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5542, N'Xã Lam Vỹ', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5551, N'Xã Kim Phượng', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5563, N'Xã Phượng Tiến', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5569, N'Xã Định Hóa', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5581, N'Xã Trung Hội', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5587, N'Xã Bình Yên', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5602, N'Xã Phú Đình', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5605, N'Xã Bình Thành', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5611, N'Xã Phú Lương', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5620, N'Xã Yên Trạch', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5632, N'Xã Hợp Thành', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5641, N'Xã Vô Tranh', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5662, N'Xã Trại Cau', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5665, N'Xã Văn Lăng', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5674, N'Xã Quang Sơn', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5680, N'Xã Văn Hán', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5692, N'Xã Đồng Hỷ', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5707, N'Xã Nam Hòa', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5710, N'Phường Linh Sơn', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5716, N'Xã Võ Nhai', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5719, N'Xã Sảng Mộc', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5722, N'Xã Nghinh Tường', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5725, N'Xã Thần Sa', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5740, N'Xã La Hiên', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5746, N'Xã Tràng Xá', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5755, N'Xã Dân Tiến', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5773, N'Xã Phú Xuyên', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5776, N'Xã Đức Lương', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5788, N'Xã Phú Lạc', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5800, N'Xã Phú Thịnh', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5809, N'Xã An Khánh', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5818, N'Xã La Bằng', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5830, N'Xã Đại Từ', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5845, N'Xã Vạn Phú', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5851, N'Xã Quân Chu', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5857, N'Phường Phúc Thuận', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5860, N'Phường Phổ Yên', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5881, N'Xã Thành Công', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5890, N'Phường Vạn Xuân', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5899, N'Phường Trung Thành', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5908, N'Xã Phú Bình', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5917, N'Xã Tân Khánh', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5923, N'Xã Tân Thành', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5941, N'Xã Điềm Thụy', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5953, N'Xã Kha Sơn', 19);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5977, N'Phường Đông Kinh', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5983, N'Phường Lương Văn Tri', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5986, N'Phường Tam Thanh', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6001, N'Xã Đoàn Kết', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6004, N'Xã Quốc Khánh', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6019, N'Xã Tân Tiến', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6037, N'Xã Kháng Chiến', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6040, N'Xã Thất Khê', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6046, N'Xã Tràng Định', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6058, N'Xã Quốc Việt', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6073, N'Xã Hoa Thám', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6076, N'Xã Quý Hòa', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6079, N'Xã Hồng Phong', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6085, N'Xã Thiện Hòa', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6091, N'Xã Thiện Thuật', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6103, N'Xã Thiện Long', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6112, N'Xã Bình Gia', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6115, N'Xã Tân Văn', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6124, N'Xã Na Sầm', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6148, N'Xã Thụy Hùng', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6151, N'Xã Hội Hoan', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6154, N'Xã Văn Lãng', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6172, N'Xã Hoàng Văn Thụ', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6184, N'Xã Đồng Đăng', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6187, N'Phường Kỳ Lừa', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6196, N'Xã Ba Sơn', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6211, N'Xã Cao Lộc', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6220, N'Xã Công Sơn', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6253, N'Xã Văn Quan', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6280, N'Xã Điềm He', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6286, N'Xã Khánh Khê', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6298, N'Xã Yên Phúc', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6313, N'Xã Tri Lễ', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6316, N'Xã Tân Đoàn', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6325, N'xã Bắc Sơn', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6337, N'Xã Tân Tri', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6349, N'Xã Hưng Vũ', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6364, N'Xã Vũ Lễ', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6367, N'Xã Vũ Lăng', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6376, N'Xã Nhất Hòa', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6385, N'Xã Hữu Lũng', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6391, N'Xã Yên Bình', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6400, N'Xã Hữu Liên', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6415, N'Xã Vân Nham', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6427, N'Xã Cai Kinh', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6436, N'Xã Thiện Tân', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6445, N'Xã Tân Thành', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6457, N'Xã Tuấn Sơn', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6463, N'Xã Chi Lăng', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6475, N'Xã Bằng Mạc', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6481, N'Xã Chiến Thắng', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6496, N'Xã Nhân Lý', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6505, N'Xã Vạn Linh', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6517, N'Xã Quan Sơn', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6526, N'Xã Na Dương', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6529, N'Xã Lộc Bình', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6541, N'Xã Mẫu Sơn', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6565, N'Xã Khuất Xá', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6577, N'Xã Thống Nhất', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6601, N'Xã Lợi Bác', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6607, N'Xã Xuân Dương', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6613, N'Xã Đình Lập', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6616, N'Xã Thái Bình', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6625, N'Xã Kiên Mộc', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6637, N'Xã Châu Sơn', 20);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6652, N'Phường Hà Tu', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6658, N'Phường Cao Xanh', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6661, N'Phường Việt Hưng', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6673, N'Phường Bãi Cháy', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6676, N'Phường Hà Lầm', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6685, N'Phường Hồng Gai', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6688, N'Phường Hạ Long', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6706, N'Phường Tuần Châu', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6709, N'Phường Móng Cái 2', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6712, N'Phường Móng Cái 1', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6724, N'Xã Hải Sơn', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6733, N'Xã Hải Ninh', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6736, N'Phường Móng Cái 3', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6757, N'Xã Vĩnh Thực', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6760, N'Phường Mông Dương', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6778, N'Phường Quang Hanh', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6781, N'Phường Cửa Ông', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6793, N'Phường Cẩm Phả', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6799, N'Xã Hải Hòa', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6811, N'Phường Uông Bí', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6820, N'Phường Vàng Danh', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6832, N'Phường Yên Tử', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6838, N'Xã Bình Liêu', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6841, N'Xã Hoành Mô', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6856, N'Xã Lục Hồn', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6862, N'Xã Tiên Yên', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6874, N'Xã Điền Xá', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6877, N'Xã Đông Ngũ', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6886, N'Xã Hải Lạng', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6895, N'Xã Đầm Hà', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6913, N'Xã Quảng Tân', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6922, N'Xã Quảng Hà', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6931, N'Xã Quảng Đức', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6946, N'Xã Đường Hoa', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6967, N'Xã Cái Chiên', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6970, N'Xã Ba Chẽ', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6979, N'Xã Kỳ Thượng', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6985, N'Xã Lương Minh', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (6994, N'Đặc khu Vân Đồn', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7030, N'Phường Hoành Bồ', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7054, N'Xã Quảng La', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7060, N'Xã Thống Nhất', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7069, N'Phường Mạo Khê', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7081, N'Phường Bình Khê', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7090, N'Phường An Sinh', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7093, N'Phường Đông Triều', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7114, N'Phường Hoàng Quế', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7132, N'Phường Quảng Yên', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7135, N'Phường Đông Mai', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7147, N'Phường Hiệp Hòa', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7168, N'Phường Hà An', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7180, N'Phường Liên Hòa', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7183, N'Phường Phong Cốc', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7192, N'Đặc khu Cô Tô', 22);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7210, N'Phường Bắc Giang', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7228, N'Phường Đa Mai', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7246, N'Xã Xuân Lương', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7264, N'Xã Tam Tiến', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7282, N'Xã Đồng Kỳ', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7288, N'Xã Yên Thế', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7294, N'Xã Bố Hạ', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7306, N'Xã Nhã Nam', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7330, N'Xã Phúc Hòa', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7333, N'Xã Quang Trung', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7339, N'Xã Tân Yên', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7351, N'Xã Ngọc Thiện', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7375, N'Xã Lạng Giang', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7381, N'Xã Tiên Lục', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7399, N'Xã Kép', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7420, N'Xã Mỹ Thái', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7432, N'Xã Tân Dĩnh', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7444, N'Xã Lục Nam', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7450, N'Xã Đông Phú', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7462, N'Xã Bảo Đài', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7486, N'Xã Nghĩa Phương', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7489, N'Xã Trường Sơn', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7492, N'Xã Lục Sơn', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7498, N'Xã Bắc Lũng', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7519, N'Xã Cẩm Lý', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7525, N'Phường Chũ', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7531, N'Xã Tân Sơn', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7534, N'Xã Sa Lý', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7537, N'Xã Biên Sơn', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7543, N'Xã Sơn Hải', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7552, N'Xã Kiên Lao', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7573, N'Xã Biển Động', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7582, N'Xã Lục Ngạn', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7594, N'Xã Đèo Gia', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7603, N'Xã Nam Dương', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7612, N'Phường Phượng Sơn', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7615, N'Xã Sơn Động', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7616, N'Xã Tây Yên Tử', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7621, N'Xã Vân Sơn', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7627, N'Xã Đại Sơn', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7642, N'Xã Yên Định', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7654, N'Xã An Lạc', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7663, N'Xã Tuấn Đạo', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7672, N'Xã Dương Hưu', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7681, N'Phường Yên Dũng', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7682, N'Phường Tân An', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7696, N'Phường Tiền Phong', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7699, N'Phường Tân Tiến', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7735, N'Xã Đồng Việt', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7738, N'Phường Cảnh Thụy', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7774, N'Phường Tự Lạn', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7777, N'Phường Việt Yên', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7795, N'Phường Nếnh', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7798, N'Phường Vân Hà', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7822, N'Xã Hoàng Vân', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7840, N'Xã Hiệp Hoà', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7864, N'Xã Hợp Thịnh', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7870, N'Xã Xuân Cẩm', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9169, N'Phường Vũ Ninh', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9187, N'Phường Kinh Bắc', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9190, N'Phường Võ Cường', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9193, N'Xã Yên Phong', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9202, N'Xã Tam Giang', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9205, N'Xã Yên Trung', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9208, N'Xã Tam Đa', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9238, N'Xã Văn Môn', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9247, N'Phường Quế Võ', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9253, N'Phường Nhân Hòa', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9265, N'Phường Phương Liễu', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9286, N'Phường Nam Sơn', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9292, N'Xã Phù Lãng', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9295, N'Phường Bồng Lai', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9301, N'Phường Đào Viên', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9313, N'Xã Chi Lăng', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9319, N'Xã Tiên Du', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9325, N'Phường Hạp Lĩnh', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9334, N'Xã Liên Bão', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9340, N'Xã Đại Đồng', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9343, N'Xã Tân Chi', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9349, N'Xã Phật Tích', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9367, N'Phường Từ Sơn', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9370, N'Phường Tam Sơn', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9379, N'Phường Phù Khê', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9385, N'Phường Đồng Nguyên', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9400, N'Phường Thuận Thành', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9409, N'Phường Mão Điền', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9427, N'Phường Trí Quả', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9430, N'Phường Trạm Lộ', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9433, N'Phường Song Liễu', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9445, N'Phường Ninh Xá', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9454, N'Xã Gia Bình', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9466, N'Xã Cao Đức', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9469, N'Xã Đại Lai', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9475, N'Xã Nhân Thắng', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9487, N'Xã Đông Cứu', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9496, N'Xã Lương Tài', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9499, N'Xã Trung Kênh', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9523, N'Xã Trung Chính', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9529, N'Xã Lâm Thao', 24);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4792, N'Phường Tân Hòa', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4795, N'Phường Hòa Bình', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4828, N'Phường Thống Nhất', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4831, N'Xã Đà Bắc', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4846, N'Xã Đức Nhàn', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4849, N'Xã Tân Pheo', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4873, N'Xã Quy Đức', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4876, N'Xã Cao Sơn', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4891, N'Xã Tiền Phong', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4894, N'Phường Kỳ Sơn', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4897, N'Xã Thịnh Minh', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4924, N'Xã Lương Sơn', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4960, N'Xã Liên Sơn', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4978, N'Xã Kim Bôi', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (4990, N'Xã Nật Sơn', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5014, N'Xã Mường Động', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5047, N'Xã Cao Dương', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5068, N'Xã Hợp Kim', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5086, N'Xã Dũng Tiến', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5089, N'Xã Cao Phong', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5092, N'Xã Thung Nai', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5116, N'Xã Mường Thàng', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5128, N'Xã Tân Lạc', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5134, N'Xã Mường Hoa', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5152, N'Xã Vân Sơn', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5158, N'Xã Mường Bi', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5191, N'Xã Toàn Thắng', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5200, N'Xã Mai Châu', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5206, N'Xã Tân Mai', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5212, N'Xã Pà Cò', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5245, N'Xã Bao La', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5251, N'Xã Mai Hạ', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5266, N'Xã Lạc Sơn', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5287, N'Xã Mường Vang', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5290, N'Xã Nhân Nghĩa', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5293, N'Xã Thượng Cốc', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5305, N'Xã Yên Phú', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5323, N'Xã Quyết Thắng', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5329, N'Xã Ngọc Sơn', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5347, N'Xã Đại Đồng', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5353, N'Xã Yên Thủy', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5362, N'Xã Lạc Lương', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5386, N'Xã Yên Trị', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5392, N'Xã Lạc Thủy', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5395, N'Xã An Nghĩa', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (5425, N'Xã An Bình', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7894, N'Phường Nông Trang', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7900, N'Phường Việt Trì', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7909, N'Phường Thanh Miếu', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7918, N'Phường Vân Phú', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7942, N'Phường Phú Thọ', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7948, N'Phường Âu Cơ', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7954, N'Phường Phong Châu', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7969, N'Xã Đoan Hùng', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7996, N'Xã Bằng Luân', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (7999, N'Xã Chí Đám', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8023, N'Xã Tây Cốc', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8038, N'Xã Chân Mộng', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8053, N'Xã Hạ Hòa', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8071, N'Xã Đan Thượng', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8110, N'Xã Hiền Lương', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8113, N'Xã Yên Kỳ', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8134, N'Xã Văn Lang', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8143, N'Xã Vĩnh Chân', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8152, N'Xã Thanh Ba', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8173, N'Xã Quảng Yên', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8203, N'Xã Hoàng Cương', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8209, N'Xã Đông Thành', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8218, N'Xã Chí Tiên', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8227, N'Xã Liên Minh', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8230, N'Xã Phù Ninh', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8236, N'Xã Phú Mỹ', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8245, N'Xã Trạm Thản', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8254, N'Xã Dân Chủ', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8275, N'Xã Bình Phú', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8290, N'Xã Yên Lập', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8296, N'Xã Sơn Lương', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8305, N'Xã Xuân Viên', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8311, N'Xã Trung Sơn', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8323, N'Xã Thượng Long', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8338, N'Xã Minh Hòa', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8341, N'Xã Cẩm Khê', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8344, N'Xã Tiên Lương', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8377, N'Xã Vân Bán', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8398, N'Xã Phú Khê', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8416, N'Xã Hùng Việt', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8431, N'Xã Đồng Lương', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8434, N'Xã Tam Nông', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8443, N'Xã Hiền Quan', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8467, N'Xã Vạn Xuân', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8479, N'Xã Thọ Văn', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8494, N'Xã Lâm Thao', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8500, N'Xã Xuân Lũng', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8515, N'Xã Hy Cương', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8521, N'Xã Phùng Nguyên', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8527, N'Xã Bản Nguyên', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8542, N'Xã Thanh Sơn', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8545, N'Xã Thu Cúc', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8560, N'Xã Lai Đồng', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8566, N'Xã Tân Sơn', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8584, N'Xã Võ Miếu', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8590, N'Xã Xuân Đài', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8593, N'Xã Minh Đài', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8611, N'Xã Văn Miếu', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8614, N'Xã Cự Đồng', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8620, N'Xã Long Cốc', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8632, N'Xã Hương Cần', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8635, N'Xã Khả Cửu', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8656, N'Xã Yên Sơn', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8662, N'Xã Đào Xá', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8674, N'Xã Thanh Thủy', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8686, N'Xã Tu Vũ', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8707, N'Phường Vĩnh Yên', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8716, N'Phường Vĩnh Phúc', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8740, N'Phường Phúc Yên', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8746, N'Phường Xuân Hòa', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8761, N'Xã Lập Thạch', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8770, N'Xã Hợp Lý', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8773, N'Xã Yên Lãng', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8782, N'Xã Hải Lựu', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8788, N'Xã Thái Hòa', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8812, N'Xã Liên Hòa', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8824, N'Xã Tam Sơn', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8842, N'Xã Tiên Lữ', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8848, N'Xã Sông Lô', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8866, N'Xã Sơn Đông', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8869, N'Xã Tam Dương', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8872, N'Xã Tam Dương Bắc', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8896, N'Xã Hoàng An', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8905, N'Xã Hội Thịnh', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8911, N'Xã Tam Đảo', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8914, N'Xã Đạo Trù', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8923, N'Xã Đại Đình', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8935, N'Xã Bình Nguyên', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8944, N'Xã Bình Tuyền', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8950, N'Xã Bình Xuyên', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (8971, N'Xã Xuân Lãng', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9025, N'Xã Yên Lạc', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9040, N'Xã Tề Lỗ', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9043, N'Xã Tam Hồng', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9052, N'Xã Nguyệt Đức', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9064, N'Xã Liên Châu', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9076, N'Xã Vĩnh Tường', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9079, N'Xã Vĩnh An', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9100, N'Xã Vĩnh Hưng', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9106, N'Xã Vĩnh Thành', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9112, N'Xã Thổ Tang', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (9154, N'Xã Vĩnh Phú', 25);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10507, N'Phường Thành Đông', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10525, N'Phường Hải Dương', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10532, N'Phường Lê Thanh Nghị', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10537, N'Phường Tân Hưng', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10543, N'Phường Việt Hòa', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10546, N'Phường Chí Linh', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10549, N'Phường Chu Văn An', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10552, N'Phường Nguyễn Trãi', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10570, N'Phường Trần Hưng Đạo', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10573, N'Phường Trần Nhân Tông', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10603, N'Phường Lê Đại Hành', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10606, N'Xã Nam Sách', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10615, N'Xã Hợp Tiến', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10633, N'Xã Trần Phú', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10642, N'Xã Thái Tân', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10645, N'Xã An Phú', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10660, N'Phường Ái Quốc', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10675, N'Phường Kinh Môn', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10678, N'Phường Bắc An Phụ', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10705, N'Xã Nam An Phụ', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10714, N'Phường Nhị Chiểu', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10726, N'Phường Phạm Sư Mạnh', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10729, N'Phường Trần Liễu', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10744, N'Phường Nguyễn Đại Năng', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10750, N'Xã Phú Thái', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10756, N'Xã Lai Khê', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10792, N'Xã An Thành', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10804, N'Xã Kim Thành', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10813, N'Xã Thanh Hà', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10816, N'Xã Hà Bắc', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10837, N'Phường Nam Đồng', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10843, N'Xã Hà Nam', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10846, N'Xã Hà Tây', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10882, N'Xã Hà Đông', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10888, N'Xã Cẩm Giang', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10891, N'Phường Tứ Minh', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10903, N'Xã Cẩm Giàng', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10909, N'Xã Tuệ Tĩnh', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10930, N'Xã Mao Điền', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10945, N'Xã Kẻ Sặt', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10966, N'Xã Bình Giang', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10972, N'Xã Đường An', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10993, N'Xã Thượng Hồng', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (10999, N'Xã Gia Lộc', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11002, N'Phường Thạch Khôi', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11020, N'Xã Yết Kiêu', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11050, N'Xã Gia Phúc', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11065, N'Xã Trường Tân', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11074, N'Xã Tứ Kỳ', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11086, N'Xã Đại Sơn', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11113, N'Xã Tân Kỳ', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11131, N'Xã Chí Minh', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11140, N'Xã Lạc Phượng', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11146, N'Xã Nguyên Giáp', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11164, N'Xã Vĩnh Lại', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11167, N'Xã Tân An', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11203, N'Xã Ninh Giang', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11218, N'Xã Hồng Châu', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11224, N'Xã Khúc Thừa Dụ', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11239, N'Xã Thanh Miện', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11242, N'Xã Nguyễn Lương Bằng', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11254, N'Xã Bắc Thanh Miện', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11257, N'Xã Hải Hưng', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11284, N'Xã Nam Thanh Miện', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11311, N'Phường Hồng Bàng', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11329, N'Phường Ngô Quyền', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11359, N'Phường Gia Viên', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11383, N'Phường Lê Chân', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11407, N'Phường An Biên', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11411, N'Phường Đông Hải', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11413, N'Phường Hải An', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11443, N'Phường Kiến An', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11446, N'Phường Phù Liễn', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11455, N'Phường Đồ Sơn', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11473, N'Phường Bạch Đằng', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11488, N'Phường Lưu Kiếm', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11503, N'Xã Việt Khê', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11506, N'Phường Lê Ích Mộc', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11533, N'Phường Hòa Bình', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11542, N'Phường Nam Triệu', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11557, N'Phường Thiên Hương', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11560, N'Phường Thủy Nguyên', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11581, N'Phường An Dương', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11593, N'Phường An Phong', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11602, N'Phường Hồng An', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11617, N'Phường An Hải', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11629, N'Xã An Lão', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11635, N'Xã An Trường', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11647, N'Xã An Quang', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11668, N'Xã An Khánh', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11674, N'Xã An Hưng', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11680, N'Xã Kiến Thụy', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11689, N'Phường Hưng Đạo', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11692, N'Phường Dương Kinh', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11713, N'Xã Nghi Dương', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11725, N'Xã Kiến Minh', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11728, N'Xã Kiến Hưng', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11737, N'Phường Nam Đồ Sơn', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11749, N'Xã Kiến Hải', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11755, N'Xã Tiên Lãng', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11761, N'Xã Quyết Thắng', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11779, N'Xã Tân Minh', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11791, N'Xã Tiên Minh', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11806, N'Xã Chấn Hưng', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11809, N'Xã Hùng Thắng', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11824, N'Xã Vĩnh Bảo', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11836, N'Xã Vĩnh Thịnh', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11842, N'Xã Vĩnh Thuận', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11848, N'Xã Vĩnh Hòa', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11875, N'Xã Vĩnh Hải', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11887, N'Xã Vĩnh Am', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11911, N'Xã Nguyễn Bỉnh Khiêm', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11914, N'Đặc khu Cát Hải', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11948, N'Đặc khu Bạch Long Vĩ', 31);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11953, N'Phường Phố Hiến', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11977, N'Xã Tân Hưng', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11980, N'Phường Hồng Châu', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11983, N'Phường Sơn Nam', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11992, N'Xã Lạc Đạo', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (11995, N'Xã Đại Đồng', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12004, N'Xã Như Quỳnh', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12019, N'Xã Văn Giang', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12025, N'Xã Phụng Công', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12031, N'Xã Nghĩa Trụ', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12049, N'Xã Mễ Sở', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12064, N'Xã Nguyễn Văn Linh', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12070, N'Xã Hoàn Long', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12073, N'Xã Yên Mỹ', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12091, N'Xã Việt Yên', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12103, N'Phường Mỹ Hào', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12127, N'Phường Thượng Hồng', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12133, N'Phường Đường Hào', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12142, N'Xã Ân Thi', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12148, N'Xã Phạm Ngũ Lão', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12166, N'Xã Xuân Trúc', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12184, N'Xã Nguyễn Trãi', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12196, N'Xã Hồng Quang', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12205, N'Xã Khoái Châu', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12223, N'Xã Triệu Việt Vương', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12238, N'Xã Việt Tiến', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12247, N'Xã Châu Ninh', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12271, N'Xã Chí Minh', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12280, N'Xã Lương Bằng', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12286, N'Xã Nghĩa Dân', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12313, N'Xã Đức Hợp', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12322, N'Xã Hiệp Cường', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12337, N'Xã Hoàng Hoa Thám', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12361, N'Xã Tiên Hoa', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12364, N'Xã Tiên Lữ', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12391, N'Xã Quang Hưng', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12406, N'Xã Đoàn Đào', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12424, N'Xã Tiên Tiến', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12427, N'Xã Tống Trân', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12452, N'Phường Trần Hưng Đạo', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12454, N'Phường Trần Lãm', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12466, N'Phường Vũ Phúc', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12472, N'Xã Quỳnh Phụ', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12499, N'Xã A Sào', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12511, N'Xã Minh Thọ', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12517, N'Xã Ngọc Lâm', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12523, N'Xã Phụ Dực', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12526, N'Xã Đồng Bằng', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12532, N'Xã Nguyễn Du', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12577, N'Xã Quỳnh An', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12583, N'Xã Tân Tiến', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12586, N'Xã Hưng Hà', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12595, N'Xã Ngự Thiên', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12613, N'Xã Long Hưng', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12619, N'Xã Diên Hà', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12631, N'Xã Thần Khê', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12634, N'Xã Tiên La', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12676, N'Xã Lê Quý Đôn', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12685, N'Xã Hồng Minh', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12688, N'Xã Đông Hưng', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12694, N'Xã Bắc Đông Hưng', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12700, N'Xã Bắc Tiên Hưng', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12736, N'Xã Đông Tiên Hưng', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12745, N'Xã Bắc Đông Quan', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12754, N'Xã Tiên Hưng', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12763, N'Xã Nam Tiên Hưng', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12775, N'Xã Nam Đông Hưng', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12793, N'Xã Đông Quan', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12817, N'Phường Trà Lý', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12826, N'Xã Thái Thụy', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12850, N'Xã Tây Thụy Anh', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12859, N'Xã Bắc Thụy Anh', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12862, N'Xã Đông Thụy Anh', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12865, N'Xã Thụy Anh', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12904, N'Xã Nam Thụy Anh', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12916, N'Xã Bắc Thái Ninh', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12919, N'Xã Tây Thái Ninh', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12922, N'Xã Thái Ninh', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12943, N'Xã Đông Thái Ninh', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12961, N'Xã Nam Thái Ninh', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12970, N'Xã Tiền Hải', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (12988, N'Xã Đông Tiền Hải', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13003, N'Xã Đồng Châu', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13021, N'Xã Ái Quốc', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13039, N'Xã Tây Tiền Hải', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13057, N'Xã Nam Cường', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13063, N'Xã Nam Tiền Hải', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13066, N'Xã Hưng Phú', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13075, N'Xã Kiến Xương', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13093, N'Xã Trà Giang', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13096, N'Xã Bình Nguyên', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13120, N'Xã Lê Lợi', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13132, N'Xã Quang Lịch', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13141, N'Xã Vũ Quý', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13159, N'Xã Hồng Vũ', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13183, N'Xã Bình Thanh', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13186, N'Xã Bình Định', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13192, N'Xã Vũ Thư', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13219, N'Xã Vạn Xuân', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13222, N'Xã Thư Trì', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13225, N'Phường Thái Bình', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13246, N'Xã Tân Thuận', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13264, N'Xã Thư Vũ', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13279, N'Xã Vũ Tiên', 33);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13285, N'Phường Phủ Lý', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13291, N'Phường Phù Vân', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13318, N'Phường Châu Sơn', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13324, N'Phường Duy Tiên', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13330, N'Phường Duy Tân', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13336, N'Phường Duy Hà', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13348, N'Phường Đồng Văn', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13363, N'Phường Tiên Sơn', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13366, N'Phường Hà Nam', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13384, N'Phường Kim Bảng', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13393, N'Phường Lê Hồ', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13396, N'Phường Nguyễn Uý', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13402, N'Phường Kim Thanh', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13420, N'Phường Tam Chúc', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13435, N'Phường Lý Thường Kiệt', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13444, N'Phường Liêm Tuyền', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13456, N'Xã Liêm Hà', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13474, N'Xã Tân Thanh', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13483, N'Xã Thanh Bình', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13489, N'Xã Thanh Lâm', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13495, N'Xã Thanh Liêm', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13501, N'Xã Bình Mỹ', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13504, N'Xã Bình Lục', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13531, N'Xã Bình Giang', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13540, N'Xã Bình An', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13558, N'Xã Bình Sơn', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13573, N'Xã Lý Nhân', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13579, N'Xã Bắc Lý', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13591, N'Xã Nam Xang', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13594, N'Xã Trần Thương', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13597, N'Xã Vĩnh Trụ', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13609, N'Xã Nhân Hà', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13627, N'Xã Nam Lý', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13669, N'Phường Nam Định', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13684, N'Phường Thiên Trường', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13693, N'Phường Đông A', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13699, N'Phường Thành Nam', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13708, N'Phường Mỹ Lộc', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13741, N'Xã Vụ Bản', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13750, N'Xã Minh Tân', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13753, N'Xã Hiển Khánh', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13777, N'Phường Trường Thi', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13786, N'Xã Liên Minh', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13795, N'Xã Ý Yên', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13807, N'Xã Tân Minh', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13822, N'Xã Phong Doanh', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13834, N'Xã Vũ Dương', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13864, N'Xã Vạn Thắng', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13870, N'Xã Yên Cường', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13879, N'Xã Yên Đồng', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13891, N'Xã Nghĩa Hưng', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13894, N'Xã Rạng Đông', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13900, N'Xã Đồng Thịnh', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13918, N'Xã Nghĩa Sơn', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13927, N'Xã Hồng Phong', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13939, N'Xã Quỹ Nhất', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13957, N'Xã Nghĩa Lâm', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13966, N'Xã Nam Trực', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13972, N'Phường Vị Khê', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13984, N'Phường Hồng Quang', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (13987, N'Xã Nam Hồng', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14005, N'Xã Nam Ninh', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14011, N'Xã Nam Minh', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14014, N'Xã Nam Đồng', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14026, N'Xã Cổ Lễ', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14038, N'Xã Ninh Giang', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14053, N'Xã Trực Ninh', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14056, N'Xã Cát Thành', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14062, N'Xã Quang Hưng', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14071, N'Xã Minh Thái', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14077, N'Xã Ninh Cường', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14089, N'Xã Xuân Trường', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14095, N'Xã Xuân Hồng', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14104, N'Xã Xuân Giang', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14122, N'Xã Xuân Hưng', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14161, N'Xã Giao Minh', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14167, N'Xã Giao Thuỷ', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14179, N'Xã Giao Hưng', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14182, N'Xã Giao Hoà', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14194, N'Xã Giao Bình', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14203, N'Xã Giao Phúc', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14212, N'Xã Giao Ninh', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14215, N'Xã Hải Hậu', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14218, N'Xã Hải Tiến', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14221, N'Xã Hải Thịnh', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14236, N'Xã Hải Anh', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14248, N'Xã Hải Hưng', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14281, N'Xã Hải An', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14287, N'Xã Hải Quang', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14308, N'Xã Hải Xuân', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14329, N'Phường Hoa Lư', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14359, N'Phường Nam Hoa Lư', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14362, N'Phường Tam Điệp', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14365, N'Phường Trung Sơn', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14371, N'Phường Yên Sơn', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14389, N'Xã Gia Lâm', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14401, N'Xã Gia Tường', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14404, N'Xã Cúc Phương', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14407, N'Xã Phú Sơn', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14428, N'Xã Nho Quan', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14434, N'Xã Thanh Sơn', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14452, N'Xã Quỳnh Lưu', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14458, N'Xã Phú Long', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14464, N'Xã Gia Viễn', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14482, N'Xã Gia Hưng', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14488, N'Xã Gia Vân', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14494, N'Xã Gia Trấn', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14500, N'Xã Đại Hoàng', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14524, N'Xã Gia Phong', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14533, N'Phường Tây Hoa Lư', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14560, N'Xã Yên Khánh', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14563, N'Xã Khánh Thiện', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14566, N'Phường Đông Hoa Lư', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14608, N'Xã Khánh Trung', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14611, N'Xã Khánh Nhạc', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14614, N'Xã Khánh Hội', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14620, N'Xã Phát Diệm', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14623, N'Xã Bình Minh', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14638, N'Xã Kim Sơn', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14647, N'Xã Quang Thiện', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14653, N'Xã Chất Bình', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14674, N'Xã Lai Thành', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14677, N'Xã Định Hóa', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14698, N'Xã Kim Đông', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14701, N'Xã Yên Mô', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14725, N'Phường Yên Thắng', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14728, N'Xã Yên Từ', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14743, N'Xã Yên Mạc', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14746, N'Xã Đồng Thái', 37);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14758, N'Phường Hàm Rồng', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14797, N'Phường Hạc Thành', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14812, N'Phường Bỉm Sơn', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14818, N'Phường Quang Trung', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14845, N'Xã Mường Lát', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14848, N'Xã Tam Chung', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14854, N'Xã Mường Lý', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14857, N'Xã Trung Lý', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14860, N'Xã Quang Chiểu', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14863, N'Xã Pù Nhi', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14864, N'Xã Nhi Sơn', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14866, N'Xã Mường Chanh', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14869, N'Xã Hồi Xuân', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14872, N'Xã Trung Thành', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14875, N'Xã Trung Sơn', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14878, N'Xã Phú Lệ', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14890, N'Xã Phú Xuân', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14896, N'Xã Hiền Kiệt', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14902, N'Xã Nam Xuân', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14908, N'Xã Thiên Phủ', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14923, N'Xã Bá Thước', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14932, N'Xã Điền Quang', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14950, N'Xã Điền Lư', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14953, N'Xã Quý Lương', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14956, N'Xã Pù Luông', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14959, N'Xã Cổ Lũng', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14974, N'Xã Văn Nho', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (14980, N'Xã Thiết Ống', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15001, N'Xã Trung Hạ', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15007, N'Xã Tam Thanh', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15010, N'Xã Sơn Thủy', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15013, N'Xã Na Mèo', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15016, N'Xã Quan Sơn', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15019, N'Xã Tam Lư', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15022, N'Xã Sơn Điện', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15025, N'Xã Mường Mìn', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15031, N'Xã Yên Khương', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15034, N'Xã Yên Thắng', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15043, N'Xã Giao An', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15049, N'Xã Văn Phú', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15055, N'Xã Linh Sơn', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15058, N'Xã Đồng Lương', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15061, N'Xã Ngọc Lặc', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15085, N'Xã Thạch Lập', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15091, N'Xã Ngọc Liên', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15106, N'Xã Nguyệt Ấn', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15112, N'Xã Kiên Thọ', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15124, N'Xã Minh Sơn', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15127, N'Xã Cẩm Thủy', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15142, N'Xã Cẩm Thạch', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15148, N'Xã Cẩm Tú', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15163, N'Xã Cẩm Vân', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15178, N'Xã Cẩm Tân', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15187, N'Xã Kim Tân', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15190, N'Xã Vân Du', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15199, N'Xã Thạch Quảng', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15211, N'Xã Thạch Bình', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15229, N'Xã Thành Vinh', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15250, N'Xã Ngọc Trạo', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15271, N'Xã Hà Trung', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15274, N'Xã Hà Long', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15286, N'Xã Hoạt Giang', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15298, N'Xã Lĩnh Toại', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15316, N'Xã Tống Sơn', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15349, N'Xã Vĩnh Lộc', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15361, N'Xã Tây Đô', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15382, N'Xã Biện Thượng', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15409, N'Xã Yên Phú', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15412, N'Xã Quý Lộc', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15421, N'Xã Yên Trường', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15442, N'Xã Yên Ninh', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15448, N'Xã Định Hòa', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15457, N'Xã Định Tân', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15469, N'Xã Yên Định', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15499, N'Xã Thọ Xuân', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15505, N'Xã Thọ Long', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15520, N'Xã Xuân Hòa', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15544, N'Xã Lam Sơn', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15553, N'Xã Sao Vàng', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15568, N'Xã Thọ Lập', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15574, N'Xã Xuân Tín', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15592, N'Xã Xuân Lập', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15607, N'Xã Bát Mọt', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15610, N'Xã Yên Nhân', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15622, N'Xã Vạn Xuân', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15628, N'Xã Lương Sơn', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15634, N'Xã Luận Thành', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15643, N'Xã Thắng Lộc', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15646, N'Xã Thường Xuân', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15658, N'Xã Xuân Chinh', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15661, N'Xã Tân Thành', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15664, N'Xã Triệu Sơn', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15667, N'Xã Thọ Bình', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15682, N'Xã Hợp Tiến', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15715, N'Xã Tân Ninh', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15724, N'Xã Đồng Tiến', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15754, N'Xã Thọ Ngọc', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15763, N'Xã Thọ Phú', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15766, N'Xã An Nông', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15772, N'Xã Thiệu Hóa', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15778, N'Xã Thiệu Tiến', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15796, N'Xã Thiệu Quang', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15820, N'Xã Thiệu Toán', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15835, N'Xã Thiệu Trung', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15853, N'Phường Đông Tiến', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15865, N'Xã Hoằng Hóa', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15880, N'Xã Hoằng Giang', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15889, N'Xã Hoằng Phú', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15910, N'Xã Hoằng Sơn', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15925, N'Phường Nguyệt Viên', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15961, N'Xã Hoằng Lộc', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15976, N'Xã Hoằng Châu', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (15991, N'Xã Hoằng Tiến', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16000, N'Xã Hoằng Thanh', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16012, N'Xã Hậu Lộc', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16021, N'Xã Triệu Lộc', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16033, N'Xã Đông Thành', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16072, N'Xã Hoa Lộc', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16078, N'Xã Vạn Lộc', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16093, N'Xã Nga Sơn', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16108, N'Xã Tân Tiến', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16114, N'Xã Nga Thắng', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16138, N'Xã Hồ Vương', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16144, N'Xã Nga An', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16171, N'Xã Ba Đình', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16174, N'Xã Như Xuân', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16177, N'Xã Xuân Bình', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16186, N'Xã Hóa Quỳ', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16213, N'Xã Thanh Phong', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16222, N'Xã Thanh Quân', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16225, N'Xã Thượng Ninh', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16228, N'Xã Như Thanh', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16234, N'Xã Xuân Du', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16249, N'Xã Mậu Lâm', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16258, N'Xã Xuân Thái', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16264, N'Xã Yên Thọ', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16273, N'Xã Thanh Kỳ', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16279, N'Xã Nông Cống', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16297, N'Xã Trung Chính', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16309, N'Xã Thắng Lợi', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16342, N'Xã Thăng Bình', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16348, N'Xã Trường Văn', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16363, N'Xã Tượng Lĩnh', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16369, N'Xã Công Chính', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16378, N'Phường Đông Sơn', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16417, N'Phường Đông Quang', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16438, N'Xã Lưu Vệ', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16480, N'Xã Quảng Yên', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16489, N'Xã Quảng Chính', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16498, N'Xã Quảng Ngọc', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16516, N'Phường Nam Sầm Sơn', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16522, N'Phường Quảng Phú', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16531, N'Phường Sầm Sơn', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16540, N'Xã Quảng Ninh', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16543, N'Xã Quảng Bình', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16549, N'Xã Tiên Trang', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16561, N'Phường Tĩnh Gia', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16576, N'Phường Ngọc Sơn', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16591, N'Xã Các Sơn', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16594, N'Phường Tân Dân', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16597, N'Phường Hải Lĩnh', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16609, N'Phường Đào Duy Từ', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16624, N'Phường Trúc Lâm', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16636, N'Xã Trường Lâm', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16645, N'Phường Hải Bình', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16654, N'Phường Nghi Sơn', 38);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16681, N'Phường Thành Vinh', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16690, N'Phường Trường Vinh', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16702, N'Phường Vinh Phú', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16708, N'Phường Vinh Lộc', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16732, N'Phường Cửa Lò', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16738, N'Xã Quế Phong', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16744, N'Xã Thông Thụ', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16750, N'Xã Tiền Phong', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16756, N'Xã Tri Lễ', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16774, N'Xã Mường Quàng', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16777, N'Xã Quỳ Châu', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16792, N'Xã Châu Tiến', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16801, N'Xã Hùng Chân', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16804, N'Xã Châu Bình', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16813, N'Xã Mường Xén', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16816, N'Xã Mỹ Lý', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16819, N'Xã Bắc Lý', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16822, N'Xã Keng Đu', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16828, N'Xã Huồi Tụ', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16831, N'Xã Mường Lống', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16834, N'Xã Na Loi', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16837, N'Xã Nậm Cắn', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16849, N'Xã Hữu Kiệm', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16855, N'Xã Chiêu Lưu', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16858, N'Xã Mường Típ', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16870, N'Xã Na Ngoi', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16876, N'Xã Tương Dương', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16882, N'Xã Nhôn Mai', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16885, N'Xã Hữu Khuông', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16903, N'Xã Nga My', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16906, N'Xã Lượng Minh', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16909, N'Xã Yên Hòa', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16912, N'Xã Yên Na', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16933, N'Xã Tam Quang', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16936, N'Xã Tam Thái', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16939, N'Phường Thái Hòa', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16941, N'Xã Nghĩa Đàn', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16951, N'Xã Nghĩa Lâm', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16969, N'Xã Nghĩa Thọ', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16972, N'Xã Nghĩa Hưng', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (16975, N'Xã Nghĩa Mai', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17011, N'Phường Tây Hiếu', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17017, N'Xã Đông Hiếu', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17029, N'Xã Nghĩa Lộc', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17032, N'Xã Nghĩa Khánh', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17035, N'Xã Quỳ Hợp', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17044, N'Xã Châu Hồng', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17056, N'Xã Châu Lộc', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17059, N'Xã Tam Hợp', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17071, N'Xã Minh Hợp', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17077, N'Xã Mường Ham', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17089, N'Xã Mường Chọng', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17110, N'Phường Hoàng Mai', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17125, N'Phường Quỳnh Mai', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17128, N'Phường Tân Mai', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17143, N'Xã Quỳnh Văn', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17149, N'Xã Quỳnh Tam', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17170, N'Xã Quỳnh Sơn', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17176, N'Xã Quỳnh Anh', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17179, N'Xã Quỳnh Lưu', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17212, N'Xã Quỳnh Phú', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17224, N'Xã Quỳnh Thắng', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17230, N'Xã Bình Chuẩn', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17239, N'Xã Mậu Thạch', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17242, N'Xã Cam Phục', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17248, N'Xã Châu Khê', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17254, N'Xã Con Cuông', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17263, N'Xã Môn Sơn', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17266, N'Xã Tân Kỳ', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17272, N'Xã Tân Phú', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17278, N'Xã Giai Xuân', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17284, N'Xã Nghĩa Đồng', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17287, N'Xã Tiên Đồng', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17305, N'Xã Tân An', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17326, N'Xã Nghĩa Hành', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17329, N'Xã Anh Sơn', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17335, N'Xã Thành Bình Thọ', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17344, N'Xã Nhân Hòa', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17357, N'Xã Vĩnh Tường', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17365, N'Xã Anh Sơn Đông', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17380, N'Xã Yên Xuân', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17395, N'Xã Hùng Châu', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17416, N'Xã Đức Châu', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17419, N'Xã Hải Châu', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17443, N'Xã Quảng Châu', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17464, N'Xã Diễn Châu', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17476, N'Xã Minh Châu', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17479, N'Xã An Châu', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17488, N'Xã Tân Châu', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17506, N'Xã Yên Thành', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17515, N'Xã Bình Minh', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17521, N'Xã Quang Đồng', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17524, N'Xã Giai Lạc', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17530, N'Xã Đông Thành', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17560, N'Xã Vân Du', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17569, N'Xã Quan Thành', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17605, N'Xã Hợp Minh', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17611, N'Xã Vân Tụ', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17623, N'Xã Bạch Ngọc', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17641, N'Xã Lương Sơn', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17662, N'Xã Đô Lương', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17677, N'Xã Văn Hiến', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17689, N'Xã Thuần Trung', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17707, N'Xã Bạch Hà', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17713, N'Xã Đại Đồng', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17722, N'Xã Hạnh Lâm', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17728, N'Xã Cát Ngạn', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17743, N'Xã Tam Đồng', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17759, N'Xã Sơn Lâm', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17770, N'Xã Hoa Quân', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17779, N'Xã Xuân Lâm', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17791, N'Xã Kim Bảng', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17818, N'Xã Bích Hào', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17827, N'Xã Nghi Lộc', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17833, N'Xã Hải Lộc', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17842, N'Xã Thần Lĩnh', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17854, N'Xã Văn Kiều', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17857, N'Xã Phúc Lộc', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17866, N'Xã Trung Lộc', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17878, N'Xã Đông Lộc', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17920, N'Phường Vinh Hưng', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17935, N'Xã Nam Đàn', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17944, N'Xã Đại Huệ', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17950, N'Xã Vạn An', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17971, N'Xã Kim Liên', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (17989, N'Xã Thiên Nhẫn', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18001, N'Xã Hưng Nguyên', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18007, N'Xã Yên Trung', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18028, N'Xã Hưng Nguyên Nam', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18040, N'Xã Lam Thành', 40);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18073, N'Phường Thành Sen', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18100, N'Phường Trần Phú', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18115, N'Phường Bắc Hồng Lĩnh', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18118, N'Phường Nam Hồng Lĩnh', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18133, N'Xã Hương Sơn', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18160, N'Xã Sơn Hồng', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18163, N'Xã Sơn Tiến', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18172, N'Xã Sơn Tây', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18184, N'Xã Sơn Giang', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18196, N'Xã Sơn Kim 1', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18199, N'Xã Sơn Kim 2', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18202, N'Xã Tứ Mỹ', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18223, N'Xã Kim Hoa', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18229, N'Xã Đức Thọ', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18244, N'Xã Đức Minh', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18262, N'Xã Đức Quang', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18277, N'Xã Đức Thịnh', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18304, N'Xã Đức Đồng', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18313, N'Xã Vũ Quang', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18322, N'Xã Mai Hoa', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18328, N'Xã Thượng Đức', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18352, N'Xã Nghi Xuân', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18364, N'Xã Đan Hải', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18373, N'Xã Tiên Điền', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18394, N'Xã Cổ Đạm', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18406, N'Xã Can Lộc', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18409, N'Xã Hồng Lộc', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18418, N'Xã Tùng Lộc', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18436, N'Xã Trường Lưu', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18466, N'Xã Gia Hanh', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18481, N'Xã Xuân Lộc', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18484, N'Xã Đồng Lộc', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18496, N'Xã Hương Khê', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18502, N'Xã Hà Linh', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18523, N'Xã Hương Bình', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18532, N'Xã Hương Phố', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18544, N'Xã Hương Xuân', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18547, N'Xã Phúc Trạch', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18550, N'Xã Hương Đô', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18562, N'Xã Thạch Hà', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18568, N'Xã Lộc Hà', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18583, N'Xã Mai Phụ', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18586, N'Xã Đông Kinh', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18601, N'Xã Việt Xuyên', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18604, N'Xã Thạch Khê', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18619, N'Xã Đồng Tiến', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18628, N'Xã Thạch Lạc', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18634, N'Xã Toàn Lưu', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18652, N'Phường Hà Huy Tập', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18667, N'Xã Thạch Xuân', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18673, N'Xã Cẩm Xuyên', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18676, N'Xã Thiên Cầm', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18682, N'Xã Yên Hòa', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18685, N'Xã Cẩm Bình', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18736, N'Xã Cẩm Hưng', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18739, N'Xã Cẩm Duệ', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18742, N'Xã Cẩm Trung', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18748, N'Xã Cẩm Lạc', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18754, N'Phường Sông Trí', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18766, N'Xã Kỳ Xuân', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18775, N'Xã Kỳ Anh', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18781, N'Phường Hải Ninh', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18787, N'Xã Kỳ Văn', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18790, N'Xã Kỳ Khang', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18814, N'Xã Kỳ Hoa', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18823, N'Phường Vũng Áng', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18832, N'Phường Hoành Sơn', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18838, N'Xã Kỳ Lạc', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18844, N'Xã Kỳ Thượng', 42);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18859, N'Phường Đồng Thuận', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18871, N'Phường Đồng Sơn', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18880, N'Phường Đồng Hới', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18901, N'Xã Minh Hóa', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18904, N'Xã Dân Hóa', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18919, N'Xã Tân Thành', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18922, N'Xã Kim Điền', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18943, N'Xã Kim Phú', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18949, N'Xã Đồng Lê', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18952, N'Xã Tuyên Sơn', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18958, N'Xã Tuyên Lâm', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18985, N'Xã Tuyên Phú', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18991, N'Xã Tuyên Bình', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (18997, N'Xã Tuyên Hóa', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19009, N'Phường Ba Đồn', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19021, N'Xã Phú Trạch', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19030, N'Xã Trung Thuần', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19033, N'Xã Hòa Trạch', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19051, N'Xã Tân Gianh', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19057, N'Xã Quảng Trạch', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19066, N'Phường Bắc Gianh', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19075, N'Xã Nam Ba Đồn', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19093, N'Xã Nam Gianh', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19111, N'Xã Hoàn Lão', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19126, N'Xã Bắc Trạch', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19138, N'Xã Phong Nha', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19141, N'Xã Bố Trạch', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19147, N'Xã Thượng Trạch', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19159, N'Xã Đông Trạch', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19198, N'Xã Nam Trạch', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19204, N'Xã Trường Sơn', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19207, N'Xã Quảng Ninh', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19225, N'Xã Ninh Châu', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19237, N'Xã Trường Ninh', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19246, N'Xã Lệ Ninh', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19249, N'Xã Lệ Thủy', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19255, N'Xã Cam Hồng', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19288, N'Xã Sen Ngư', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19291, N'Xã Tân Mỹ', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19309, N'Xã Trường Phú', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19318, N'Xã Kim Ngân', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19333, N'Phường Đông Hà', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19351, N'Phường Nam Đông Hà', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19360, N'Phường Quảng Trị', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19363, N'Xã Vĩnh Linh', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19366, N'Xã Bến Quan', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19372, N'Xã Vĩnh Hoàng', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19405, N'Xã Vĩnh Thủy', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19414, N'Xã Cửa Tùng', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19429, N'Xã Khe Sanh', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19432, N'Xã Lao Bảo', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19435, N'Xã Hướng Lập', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19441, N'Xã Hướng Phùng', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19462, N'Xã Tân Lập', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19483, N'Xã A Dơi', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19489, N'Xã Lìa', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19495, N'Xã Gio Linh', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19496, N'Xã Cửa Việt', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19501, N'Xã Bến Hải', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19537, N'Xã Cồn Tiên', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19555, N'Xã Hướng Hiệp', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19564, N'Xã Đakrông', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19567, N'Xã Ba Lòng', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19588, N'Xã Tà Rụt', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19594, N'Xã La Lay', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19597, N'Xã Cam Lộ', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19603, N'Xã Hiếu Giang', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19624, N'Xã Triệu Phong', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19639, N'Xã Nam Cửa Việt', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19645, N'Xã Triệu Bình', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19654, N'Xã Triệu Cơ', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19669, N'Xã Ái Tử', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19681, N'Xã Diên Sanh', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19699, N'Xã Vĩnh Định', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19702, N'Xã Hải Lăng', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19735, N'Xã Nam Hải Lăng', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19741, N'Xã Mỹ Thủy', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19742, N'Đặc khu Cồn Cỏ', 44);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19753, N'Phường Phú Xuân', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19774, N'Phường Kim Long', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19777, N'Phường Vỹ Dạ', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19789, N'Phường Thuận Hóa', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19804, N'Phường Hương An', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19813, N'Phường Thủy Xuân', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19815, N'Phường An Cựu', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19819, N'Phường Phong Điền', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19828, N'Phường Phong Phú', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19831, N'Phường Phong Dinh', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19858, N'Phường Phong Thái', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19867, N'Xã Quảng Điền', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19873, N'Phường Phong Quảng', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19885, N'Xã Đan Điền', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19900, N'Phường Thuận An', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19909, N'Phường Dương Nỗ', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19918, N'Xã Phú Hồ', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19930, N'Phường Mỹ Thượng', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19942, N'Xã Phú Vang', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19945, N'Xã Phú Vinh', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19960, N'Phường Phú Bài', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19969, N'Phường Thanh Thủy', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19975, N'Phường Hương Thủy', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (19996, N'Phường Hương Trà', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20014, N'Phường Hóa Châu', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20017, N'Phường Kim Trà', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20035, N'Xã Bình Điền', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20044, N'Xã A Lưới 2', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20050, N'Xã A Lưới 5', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20056, N'Xã A Lưới 1', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20071, N'Xã A Lưới 3', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20101, N'Xã A Lưới 4', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20107, N'Xã Phú Lộc', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20122, N'Xã Vinh Lộc', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20131, N'Xã Hưng Lộc', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20137, N'Xã Chân Mây - Lăng Cô', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20140, N'Xã Lộc An', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20161, N'Xã Khe Tre', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20179, N'Xã Nam Đông', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20182, N'Xã Long Quảng', 46);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20194, N'Phường Hải Vân', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20197, N'Phường Liên Chiểu', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20200, N'Phường Hòa Khánh', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20209, N'Phường Thanh Khê', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20242, N'Phường Hải Châu', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20257, N'Phường Hòa Cường', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20260, N'Phường Cẩm Lệ', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20263, N'Phường Sơn Trà', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20275, N'Phường An Hải', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20285, N'Phường Ngũ Hành Sơn', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20305, N'Phường An Khê', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20308, N'Xã Bà Nà', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20314, N'Phường Hòa Xuân', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20320, N'Xã Hòa Vang', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20332, N'Xã Hòa Tiến', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20333, N'Đặc khu Hoàng Sa', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20335, N'Phường Bàn Thạch', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20341, N'Phường Tam Kỳ', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20350, N'Phường Hương Trà', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20356, N'Phường Quảng Phú', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20364, N'Xã Chiên Đàn', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20380, N'Xã Tây Hồ', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20392, N'Xã Phú Ninh', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20401, N'Phường Hội An Tây', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20410, N'Phường Hội An', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20413, N'Phường Hội An Đông', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20434, N'Xã Tân Hiệp', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20443, N'Xã Hùng Sơn', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20455, N'Xã Tây Giang', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20458, N'Xã Avương', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20467, N'Xã Đông Giang', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20476, N'Xã Sông Kôn', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20485, N'Xã Sông Vàng', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20494, N'Xã Bến Hiên', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20500, N'Xã Đại Lộc', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20506, N'Xã Thượng Đức', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20515, N'Xã Hà Nha', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20539, N'Xã Vu Gia', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20542, N'Xã Phú Thuận', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20551, N'Phường Điện Bàn', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20557, N'Phường Điện Bàn Bắc', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20569, N'Xã Điện Bàn Tây', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20575, N'Phường An Thắng', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20579, N'Phường Điện Bàn Đông', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20587, N'Xã Gò Nổi', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20599, N'Xã Nam Phước', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20611, N'Xã Thu Bồn', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20623, N'Xã Duy Xuyên', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20635, N'Xã Duy Nghĩa', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20641, N'Xã Quế Sơn', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20650, N'Xã Xuân Phú', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20656, N'Xã Nông Sơn', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20662, N'Xã Quế Sơn Trung', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20669, N'Xã Quế Phước', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20695, N'Xã Thạnh Mỹ', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20698, N'Xã La Êê', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20704, N'Xã La Dêê', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20707, N'Xã Nam Giang', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20710, N'Xã Bến Giằng', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20716, N'Xã Đắc Pring', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20722, N'Xã Khâm Đức', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20728, N'Xã Phước Hiệp', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20734, N'Xã Phước Năng', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20740, N'Xã Phước Chánh', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20752, N'Xã Phước Thành', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20767, N'Xã Việt An', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20770, N'Xã Phước Trà', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20779, N'Xã Hiệp Đức', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20791, N'Xã Thăng Bình', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20794, N'Xã Thăng An', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20818, N'Xã Đồng Dương', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20827, N'Xã Thăng Phú', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20836, N'Xã Thăng Trường', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20848, N'Xã Thăng Điền', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20854, N'Xã Tiên Phước', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20857, N'Xã Sơn Cẩm Hà', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20875, N'Xã Lãnh Ngọc', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20878, N'Xã Thạnh Bình', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20900, N'Xã Trà My', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20908, N'Xã Trà Liên', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20920, N'Xã Trà Đốc', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20923, N'Xã Trà Tân', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20929, N'Xã Trà Giáp', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20938, N'Xã Trà Leng', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20941, N'Xã Trà Tập', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20944, N'Xã Nam Trà My', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20950, N'Xã Trà Linh', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20959, N'Xã Trà Vân', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20965, N'Xã Núi Thành', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20971, N'Xã Tam Xuân', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20977, N'Xã Đức Phú', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20984, N'Xã Tam Anh', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (20992, N'Xã Tam Hải', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21004, N'Xã Tam Mỹ', 48);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21025, N'Phường Cẩm Thành', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21028, N'Phường Nghĩa Lộ', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21034, N'Xã An Phú', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21040, N'Xã Bình Sơn', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21061, N'Xã Vạn Tường', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21085, N'Xã Bình Minh', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21100, N'Xã Bình Chương', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21109, N'Xã Đông Sơn', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21115, N'Xã Trà Bồng', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21124, N'Xã Thanh Bồng', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21127, N'Xã Đông Trà Bồng', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21136, N'Xã Cà Đam', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21154, N'Xã Tây Trà', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21157, N'Xã Tây Trà Bồng', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21172, N'Phường Trương Quang Trọng', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21181, N'Xã Thọ Phong', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21196, N'Xã Trường Giang', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21205, N'Xã Ba Gia', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21211, N'Xã Tịnh Khê', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21220, N'Xã Sơn Tịnh', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21235, N'Xã Tư Nghĩa', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21238, N'Xã Vệ Giang', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21244, N'Xã Trà Giang', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21250, N'Xã Nghĩa Giang', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21289, N'Xã Sơn Hà', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21292, N'Xã Sơn Hạ', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21307, N'Xã Sơn Linh', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21319, N'Xã Sơn Thủy', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21325, N'Xã Sơn Kỳ', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21334, N'Xã Sơn Tây Thượng', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21340, N'Xã Sơn Tây', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21343, N'Xã Sơn Tây Hạ', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21349, N'Xã Sơn Mai', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21361, N'Xã Minh Long', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21364, N'Xã Nghĩa Hành', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21370, N'Xã Phước Giang', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21385, N'Xã Đình Cương', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21388, N'Xã Thiện Tín', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21400, N'Xã Mộ Đức', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21409, N'Xã Long Phụng', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21421, N'Xã Mỏ Cày', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21433, N'Xã Lân Phong', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21439, N'Phường Đức Phổ', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21451, N'Phường Trà Câu', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21457, N'Xã Nguyễn Nghiêm', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21472, N'Xã Khánh Cường', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21478, N'Phường Sa Huỳnh', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21484, N'Xã Ba Tơ', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21490, N'Xã Ba Vinh', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21496, N'Xã Ba Động', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21499, N'Xã Ba Dinh', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21520, N'Xã Đặng Thùy Trâm', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21523, N'Xã Ba Tô', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21529, N'Xã Ba Vì', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21538, N'Xã Ba Xa', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21548, N'Đặc khu Lý Sơn', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23284, N'Phường Đăk Cấm', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23293, N'Phường Kon Tum', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23302, N'Phường Đăk Bla', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23317, N'Xã Ngọk Bay', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23326, N'Xã Ia Chim', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23332, N'Xã Đăk Rơ Wa', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23341, N'Xã Đăk Pék', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23344, N'Xã Đăk Plô', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23356, N'Xã Xốp', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23365, N'Xã Ngọc Linh', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23368, N'Xã Đăk Long', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23374, N'Xã Đăk Môn', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23377, N'Xã Bờ Y', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23383, N'Xã Dục Nông', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23392, N'Xã Sa Loong', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23401, N'Xã Đăk Tô', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23416, N'Xã Đăk Sao', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23419, N'Xã Đăk Tờ Kan', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23425, N'Xã Tu Mơ Rông', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23428, N'Xã Ngọk Tụ', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23430, N'Xã Kon Đào', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23446, N'Xã Măng Ri', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23455, N'Xã Măng Bút', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23473, N'Xã Măng Đen', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23476, N'Xã Kon Plông', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23479, N'Xã Đăk Rve', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23485, N'Xã Đăk Kôi', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23497, N'Xã Kon Braih', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23500, N'Xã Đăk Hà', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23504, N'Xã Đăk Pxi', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23510, N'Xã Đăk Ui', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23512, N'Xã Đăk Mar', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23515, N'Xã Ngọk Réo', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23527, N'Xã Sa Thầy', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23530, N'Xã Rờ Kơi', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23534, N'Xã Sa Bình', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23535, N'Xã Ia Đal', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23536, N'Xã Mô Rai', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23538, N'Xã Ia Tơi', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23548, N'Xã Ya Ly', 51);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21553, N'Phường Quy Nhơn Bắc', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21583, N'Phường Quy Nhơn', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21589, N'Phường Quy Nhơn Tây', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21592, N'Phường Quy Nhơn Nam', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21601, N'Phường Quy Nhơn Đông', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21607, N'Xã Nhơn Châu', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21609, N'Xã An Lão', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21616, N'Xã An Vinh', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21622, N'Xã An Toàn', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21628, N'Xã An Hòa', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21637, N'Phường Tam Quan', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21640, N'Phường Bồng Sơn', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21655, N'Phường Hoài Nhơn Bắc', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21661, N'Phường Hoài Nhơn Tây', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21664, N'Phường Hoài Nhơn', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21670, N'Phường Hoài Nhơn Đông', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21673, N'Phường Hoài Nhơn Nam', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21688, N'Xã Hoài Ân', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21697, N'Xã Ân Hảo', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21703, N'Xã Vạn Đức', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21715, N'Xã Ân Tường', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21727, N'Xã Kim Sơn', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21730, N'Xã Phù Mỹ', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21733, N'Xã Bình Dương', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21739, N'Xã Phù Mỹ Bắc', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21751, N'Xã Phù Mỹ Đông', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21757, N'Xã Phù Mỹ Tây', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21769, N'Xã An Lương', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21775, N'Xã Phù Mỹ Nam', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21786, N'Xã Vĩnh Thạnh', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21787, N'Xã Vĩnh Sơn', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21796, N'Xã Vĩnh Thịnh', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21805, N'Xã Vĩnh Quang', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21808, N'Xã Tây Sơn', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21817, N'Xã Bình Hiệp', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21820, N'Xã Bình Khê', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21829, N'Xã Bình An', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21835, N'Xã Bình Phú', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21853, N'Xã Phù Cát', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21859, N'Xã Đề Gi', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21868, N'Xã Hội Sơn', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21871, N'Xã Hòa Hội', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21880, N'Xã Cát Tiến', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21892, N'Xã Xuân An', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21901, N'Xã Ngô Mây', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21907, N'Phường Bình Định', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21910, N'Phường An Nhơn', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21925, N'Phường An Nhơn Bắc', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21934, N'Phường An Nhơn Đông', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21940, N'Xã An Nhơn Tây', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21943, N'Phường An Nhơn Nam', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21952, N'Xã Tuy Phước', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21964, N'Xã Tuy Phước Bắc', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21970, N'Xã Tuy Phước Đông', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21985, N'Xã Tuy Phước Tây', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21994, N'Xã Vân Canh', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (21997, N'Xã Canh Liên', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22006, N'Xã Canh Vinh', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23563, N'Phường Diên Hồng', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23575, N'Phường Pleiku', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23584, N'Phường Thống Nhất', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23586, N'Phường Hội Phú', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23590, N'Xã Biển Hồ', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23602, N'Phường An Phú', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23611, N'Xã Gào', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23614, N'Phường An Bình', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23617, N'Phường An Khê', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23629, N'Xã Cửu An', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23638, N'Xã Kbang', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23644, N'Xã Đak Rong', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23647, N'Xã Sơn Lang', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23650, N'Xã Krong', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23668, N'Xã Tơ Tung', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23674, N'Xã Kông Bơ La', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23677, N'Xã Đak Đoa', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23683, N'Xã Đak Sơmei', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23701, N'Xã Kon Gang', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23710, N'Xã Ia Băng', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23714, N'Xã KDang', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23722, N'Xã Chư Păh', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23728, N'Xã Ia Khươl', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23734, N'Xã Ia Ly', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23749, N'Xã Ia Phí', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23764, N'Xã Ia Grai', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23767, N'Xã Ia Hrung', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23776, N'Xã Ia Krái', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23782, N'Xã Ia O', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23788, N'Xã Ia Chia', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23794, N'Xã Mang Yang', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23798, N'Xã Ayun', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23799, N'Xã Hra', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23812, N'Xã Lơ Pang', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23818, N'Xã Kon Chiêng', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23824, N'Xã Kông Chro', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23830, N'Xã Chư Krey', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23833, N'Xã Ya Ma', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23839, N'Xã SRó', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23842, N'Xã Đăk Song', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23851, N'Xã Chơ Long', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23857, N'Xã Đức Cơ', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23866, N'Xã Ia Krêl', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23869, N'Xã Ia Dơk', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23872, N'Xã Ia Dom', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23881, N'Xã Ia Pnôn', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23884, N'Xã Ia Nan', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23887, N'Xã Chư Prông', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23896, N'Xã Bàu Cạn', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23908, N'Xã Ia Tôr', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23911, N'Xã Ia Boòng', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23917, N'Xã Ia Púch', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23926, N'Xã Ia Pia', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23935, N'Xã Ia Lâu', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23938, N'Xã Ia Mơ', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23941, N'Xã Chư Sê', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23942, N'Xã Chư Pưh', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23947, N'Xã Bờ Ngoong', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23954, N'Xã Al Bá', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23971, N'Xã Ia Hrú', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23977, N'Xã Ia Ko', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23986, N'Xã Ia Le', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23995, N'Xã Đak Pơ', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24007, N'Xã Ya Hội', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24013, N'Xã Pờ Tó', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24022, N'Xã Ia Pa', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24028, N'Xã Ia Tul', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24043, N'Xã Phú Thiện', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24044, N'Phường Ayun Pa', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24049, N'Xã Chư A Thai', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24061, N'Xã Ia Hiao', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24065, N'Xã Ia Rbol', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24073, N'Xã Ia Sao', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24076, N'Xã Phú Túc', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24100, N'Xã Ia Dreh', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24109, N'Xã Uar', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24112, N'Xã Ia Rsai', 52);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22333, N'Phường Bắc Nha Trang', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22366, N'Phường Nha Trang', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22390, N'Phường Tây Nha Trang', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22402, N'Phường Nam Nha Trang', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22411, N'Phường Bắc Cam Ranh', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22420, N'Phường Cam Ranh', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22423, N'Phường Ba Ngòi', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22432, N'Phường Cam Linh', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22435, N'Xã Cam Hiệp', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22453, N'Xã Cam Lâm', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22465, N'Xã Cam An', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22480, N'Xã Nam Cam Ranh', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22489, N'Xã Vạn Ninh', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22498, N'Xã Tu Bông', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22504, N'Xã Đại Lãnh', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22516, N'Xã Vạn Thắng', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22525, N'Xã Vạn Hưng', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22528, N'Phường Ninh Hòa', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22546, N'Xã Bắc Ninh Hòa', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22552, N'Xã Tây Ninh Hòa', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22558, N'Xã Hòa Trí', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22561, N'Phường Đông Ninh Hòa', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22576, N'Xã Tân Định', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22591, N'Phường Hòa Thắng', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22597, N'Xã Nam Ninh Hòa', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22609, N'Xã Khánh Vĩnh', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22612, N'Xã Trung Khánh Vĩnh', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22615, N'Xã Bắc Khánh Vĩnh', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22624, N'Xã Tây Khánh Vĩnh', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22648, N'Xã Nam Khánh Vĩnh', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22651, N'Xã Diên Khánh', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22657, N'Xã Diên Điền', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22660, N'Xã Diên Lâm', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22672, N'Xã Diên Thọ', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22678, N'Xã Diên Lạc', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22702, N'Xã Suối Hiệp', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22708, N'Xã Suối Dầu', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22714, N'Xã Khánh Sơn', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22720, N'Xã Tây Khánh Sơn', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22732, N'Xã Đông Khánh Sơn', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22736, N'Đặc khu Trường Sa', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22738, N'Phường Đô Vinh', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22741, N'Phường Bảo An', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22759, N'Phường Phan Rang', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22780, N'Phường Đông Hải', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22786, N'Xã Bác Ái Tây', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22795, N'Xã Bác Ái', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22801, N'Xã Bác Ái Đông', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22810, N'Xã Ninh Sơn', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22813, N'Xã Lâm Sơn', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22822, N'Xã Mỹ Sơn', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22828, N'Xã Anh Dũng', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22834, N'Phường Ninh Chử', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22840, N'Xã Công Hải', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22846, N'Xã Vĩnh Hải', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22849, N'Xã Thuận Bắc', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22852, N'Xã Ninh Hải', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22861, N'Xã Xuân Hải', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22870, N'Xã Ninh Phước', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22873, N'Xã Phước Hậu', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22888, N'Xã Phước Dinh', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22891, N'Xã Phước Hữu', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22897, N'Xã Thuận Nam', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22900, N'Xã Phước Hà', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22909, N'Xã Cà Ná', 56);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22015, N' Phường Tuy Hòa', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22045, N' Phường Bình Kiến', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22051, N' Phường Sông Cầu', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22057, N'Xã Xuân Lộc', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22060, N'Xã Xuân Cảnh', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22075, N'Xã Xuân Thọ', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22076, N' Phường Xuân Đài', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22081, N'Xã Đồng Xuân', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22090, N'Xã Xuân Lãnh', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22096, N'Xã Phú Mỡ', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22111, N'Xã Xuân Phước', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22114, N'Xã Tuy An Bắc', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22120, N'Xã Tuy An Đông', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22132, N'Xã Tuy An Tây', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22147, N'Xã Ô Loan', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22153, N'Xã Tuy An Nam', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22165, N'Xã Sơn Hòa', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22171, N'Xã Tây Sơn', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22177, N'Xã Vân Hòa', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22192, N'Xã Suối Trai', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22207, N'Xã Sông Hinh', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22222, N'Xã Đức Bình', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22225, N'Xã Ea Bá', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22237, N'Xã Ea Ly', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22240, N'  Phường Phú Yên', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22250, N'Xã Sơn Thành', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22255, N'Xã Tây Hòa', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22258, N' Phường Đông Hòa', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22261, N' Phường Hòa Hiệp', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22276, N'Xã Hòa Thịnh', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22285, N'Xã Hòa Mỹ', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22291, N'Xã Hòa Xuân', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22303, N'Xã Phú Hòa 2', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22319, N'Xã Phú Hòa 1', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24121, N' Phường Tân Lập', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24133, N' Phường Buôn Ma Thuột', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24154, N' Phường Thành Nhất', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24163, N' Phường Tân An', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24169, N' Phường Ea Kao', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24175, N'Xã Hòa Phú', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24181, N'Xã Ea Drăng', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24184, N'Xã Ea H’Leo', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24187, N'Xã Ea Hiao', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24193, N'Xã Ea Wy', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24208, N'Xã Ea Khăl', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24211, N'Xã Ea Súp', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24214, N'Xã Ia Lốp', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24217, N'Xã Ea Rốk', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24221, N'Xã Ia Rvê', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24229, N'Xã Ea Bung', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24235, N'Xã Buôn Đôn', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24241, N'Xã Ea Wer', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24250, N'Xã Ea Nuôl', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24259, N'Xã Quảng Phú', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24265, N'Xã Ea Kiết', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24277, N'Xã Ea Tul', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24280, N'Xã Cư M’gar', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24286, N'Xã Ea M’Droh', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24301, N'Xã Cuôr Đăng', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24305, N' Phường Buôn Hồ', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24310, N'Xã Krông Búk', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24313, N'Xã Cư Pơng', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24316, N'Xã Pơng Drang', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24328, N'Xã Ea Drông', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24340, N' Phường Cư Bao', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24343, N'Xã Krông Năng', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24346, N'Xã Dliê Ya', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24352, N'Xã Tam Giang', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24364, N'Xã Phú Xuân', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24373, N'Xã Ea Kar', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24376, N'Xã Ea Knốp', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24400, N'Xã Ea Păl', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24403, N'Xã Ea Ô', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24406, N'Xã Cư Yang', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24412, N'Xã M’Drắk', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24415, N'Xã Cư Prao', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24433, N'Xã Ea Riêng', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24436, N'Xã Cư M’ta', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24444, N'Xã Krông Á', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24445, N'Xã Ea Trang', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24448, N'Xã Krông Bông', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24454, N'Xã Dang Kang', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24472, N'Xã Hòa Sơn', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24478, N'Xã Cư Pui', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24484, N'Xã Yang Mao', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24490, N'Xã Krông Pắc', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24496, N'Xã Ea Kly', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24502, N'Xã Ea Phê', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24505, N'Xã Ea Knuếc', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24526, N'Xã Tân Tiến', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24529, N'Xã Vụ Bổn', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24538, N'Xã Krông Ana', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24540, N'Xã Ea Ning', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24544, N'Xã Ea Ktur', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24559, N'Xã Ea Na', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24561, N'Xã Dray Bhăng', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24568, N'Xã Dur Kmăl', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24580, N'Xã Liên Sơn Lắk', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24595, N'Xã Đắk Liêng', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24598, N'Xã Đắk Phơi', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24604, N'Xã Krông Nô', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24607, N'Xã Nam Ka', 66);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22918, N'Phường Mũi Né', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22924, N'Phường Phú Thuỷ', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22933, N'Phường Hàm Thắng', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22945, N'Phường Phan Thiết', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22954, N'Phường Tiến Thành', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22960, N'Phường Bình Thuận', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22963, N'Xã Tuyên Quang', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22969, N'Xã Liên Hương', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22972, N'Xã Phan Rí Cửa', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22978, N'Xã Tuy Phong', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (22981, N'Xã Vĩnh Hảo', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23005, N'Xã Bắc Bình', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23008, N'Xã Phan Sơn', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23020, N'Xã Hải Ninh', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23023, N'Xã Sông Lũy', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23032, N'Xã Lương Sơn', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23041, N'Xã Hồng Thái', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23053, N'Xã Hòa Thắng', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23059, N'Xã Hàm Thuận', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23065, N'Xã La Dạ', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23074, N'Xã Đông Giang', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23086, N'Xã Hồng Sơn', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23089, N'Xã Hàm Thuận Bắc', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23095, N'Xã Hàm Liêm', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23110, N'Xã Hàm Thuận Nam', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23122, N'Xã Hàm Thạnh', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23128, N'Xã Hàm Kiệm', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23134, N'Xã Tân Lập', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23143, N'Xã Tân Thành', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23149, N'Xã Tánh Linh', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23152, N'Xã Bắc Ruộng', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23158, N'Xã Nghị Đức', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23173, N'Xã Đồng Kho', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23188, N'Xã Suối Kiết', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23191, N'Xã Đức Linh', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23194, N'Xã Hoài Đức', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23200, N'Xã Nam Thành', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23227, N'Xã Trà Tân', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23230, N'Xã Tân Minh', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23231, N'Phường Phước Hội', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23235, N'Phường La Gi', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23236, N'Xã Hàm Tân', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23246, N'Xã Tân Hải', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23266, N'Xã Sơn Mỹ', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (23272, N'Đặc khu Phú Quý', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24611, N'Phường Bắc Gia Nghĩa', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24615, N'Phường Nam Gia Nghĩa', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24616, N'Xã Quảng Sơn', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24617, N'Phường Đông Gia Nghĩa', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24620, N'Xã Quảng Hòa', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24631, N'Xã Quảng Khê', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24637, N'Xã Tà Đùng', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24640, N'Xã Cư Jút', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24646, N'Xã Đắk Wil', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24649, N'Xã Nam Dong', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24664, N'Xã Đức Lập', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24670, N'Xã Đắk Mil', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24678, N'Xã Đắk Sắk', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24682, N'Xã Thuận An', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24688, N'Xã Krông Nô', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24697, N'Xã Nam Đà', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24703, N'Xã Nâm Nung', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24712, N'Xã Quảng Phú', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24717, N' Xã Đức An', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24718, N'Xã Đắk Song', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24722, N'Xã Thuận Hạnh', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24730, N'Xã Trường Xuân', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24733, N'Xã Kiến Đức', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24736, N'Xã Quảng Trực', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24739, N'Xã Tuy Đức', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24748, N'Xã Quảng Tân', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24751, N'Xã Nhân Cơ', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24760, N'Xã Quảng Tín', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24778, N'Phường Lâm Viên - Đà Lạt', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24781, N'Phường Xuân Hương - Đà Lạt', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24787, N'Phường Cam Ly - Đà Lạt', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24805, N'Phường Xuân Trường - Đà Lạt', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24820, N'Phường 2 Bảo Lộc', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24823, N'Phường 1 Bảo Lộc', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24829, N'Phường B’Lao', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24841, N'Phường 3 Bảo Lộc', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24846, N'Phường Lang Biang - Đà Lạt', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24848, N'Xã Lạc Dương', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24853, N'Xã Đam Rông 4', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24868, N'Xã Nam Ban Lâm Hà', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24871, N'Xã Đinh Văn Lâm Hà', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24875, N'Xã Đam Rông 3', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24877, N'Xã Đam Rông 2', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24883, N'Xã Nam Hà Lâm Hà', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24886, N'Xã Đam Rông 1', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24895, N'Xã Phú Sơn Lâm Hà', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24907, N'Xã Phúc Thọ Lâm Hà', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24916, N'Xã Tân Hà Lâm Hà', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24931, N'Xã Đơn Dương', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24934, N'Xã D’Ran', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24943, N'Xã Ka Đô', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24955, N'Xã Quảng Lập', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24958, N'Xã Đức Trọng', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24967, N'Xã Hiệp Thạnh', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24976, N'Xã Tân Hội', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24985, N'Xã Ninh Gia', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24988, N'Xã Tà Năng', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (24991, N'Xã Tà Hine', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25000, N'Xã Di Linh', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25007, N'Xã Đinh Trang Thượng', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25015, N'Xã Gia Hiệp', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25018, N'Xã Bảo Thuận', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25036, N'Xã Hòa Ninh', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25042, N'Xã Hòa Bắc', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25051, N'Xã Sơn Điền', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25054, N'Xã Bảo Lâm 1', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25057, N'Xã Bảo Lâm 5', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25063, N'Xã Bảo Lâm 4', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25084, N'Xã Bảo Lâm 2', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25093, N'Xã Bảo Lâm 3', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25099, N'Xã Đạ Huoai', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25105, N'Xã Đạ Huoai 2', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25114, N'Xã Đạ Huoai 3', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25126, N'Xã Đạ Tẻh', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25135, N'Xã Đạ Tẻh 3', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25138, N'Xã Đạ Tẻh 2', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25159, N'Xã Cát Tiên', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25162, N'Xã Cát Tiên 3', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25180, N'Xã Cát Tiên 2', 68);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25195, N'Phường Bình Phước', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25210, N'Phường Đồng Xoài', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25217, N'Phường Phước Long', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25220, N'Phường Phước Bình', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25222, N'Xã Bù Gia Mập', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25225, N'Xã Đăk Ơ', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25231, N'Xã Đa Kia', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25246, N'Xã Bình Tân', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25252, N'Xã Phú Riềng', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25255, N'Xã Long Hà', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25261, N'Xã Phú Trung', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25267, N'Xã Phú Nghĩa', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25270, N'Xã Lộc Ninh', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25279, N'Xã Lộc Tấn', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25280, N'Xã Lộc Thạnh', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25292, N'Xã Lộc Quang', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25294, N'Xã Lộc Thành', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25303, N'Xã Lộc Hưng', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25308, N'Xã Thiện Hưng', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25309, N'Xã Hưng Phước', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25318, N'Xã Tân Tiến', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25326, N'Phường Bình Long', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25333, N'Phường An Lộc', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25345, N'Xã Tân Hưng', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25349, N'Xã Minh Đức', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25351, N'Xã Tân Quan', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25357, N'Xã Tân Khai', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25363, N'Xã Đồng Phú', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25378, N'Xã Tân Lợi', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25387, N'Xã Thuận Lợi', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25390, N'Xã Đồng Tâm', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25396, N'Xã Bù Đăng', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25399, N'Xã Đak Nhau', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25402, N'Xã Thọ Sơn', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25405, N'Xã Bom Bo', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25417, N'Xã Nghĩa Trung', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25420, N'Xã Phước Sơn', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25432, N'Phường Chơn Thành', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25441, N'Phường Minh Hưng', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25450, N'Xã Nha Bích', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25993, N'Phường Trảng Dài', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26005, N'Phường Hố Nai', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26017, N'Phường Tam Hiệp', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26020, N'Phường Long Bình', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26041, N'Phường Trấn Biên', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26068, N'Phường Biên Hòa', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26080, N'Phường Long Khánh', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26089, N'Phường Bình Lộc', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26098, N'Phường Bảo Vinh', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26104, N'Phường Xuân Lập', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26113, N'Phường Hàng Gòn', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26116, N'Xã Tân Phú', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26119, N'Xã Đak Lua', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26122, N'Xã Nam Cát Tiên', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26134, N'Xã Tà Lài', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26158, N'Xã Phú Lâm', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26170, N'Xã Trị An', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26173, N'Xã Phú Lý', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26179, N'Xã Tân An', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26188, N'Phường Tân Triều', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26206, N'Xã Định Quán', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26209, N'Xã Thanh Sơn', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26215, N'Xã Phú Vinh', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26221, N'Xã Phú Hòa', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26227, N'Xã La Ngà', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26248, N'Xã Trảng Bom', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26254, N'Xã Bàu Hàm', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26278, N'Xã Bình Minh', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26281, N'Xã Hưng Thịnh', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26296, N'Xã An Viễn', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26299, N'Xã Thống Nhất', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26311, N'Xã Gia Kiệm', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26326, N'Xã Dầu Giây', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26332, N'Xã Xuân Quế', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26341, N'Xã Cẩm Mỹ', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26347, N'Xã Xuân Đường', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26359, N'Xã Xuân Đông', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26362, N'Xã Sông Ray', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26368, N'Xã Long Thành', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26374, N'Phường Tam Phước', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26377, N'Phường Phước Tân', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26380, N'Phường Long Hưng', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26383, N'Xã An Phước', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26389, N'Xã Bình An', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26413, N'Xã Long Phước', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26422, N'Xã Phước Thái', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26425, N'Xã Xuân Lộc', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26428, N'Xã Xuân Bắc', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26434, N'Xã Xuân Thành', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26446, N'Xã Xuân Hòa', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26458, N'Xã Xuân Phú', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26461, N'Xã Xuân Định', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26485, N'Xã Nhơn Trạch', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26491, N'Xã Đại Phước', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26503, N'Xã Phước An', 75);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25747, N'Phường Thủ Dầu Một', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25750, N'Phường Phú Lợi', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25760, N'Phường Bình Dương', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25768, N'Phường Phú An', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25771, N'Phường Chánh Hiệp', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25777, N'Xã Dầu Tiếng', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25780, N'Xã Minh Thạnh', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25792, N'Xã Long Hòa', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25807, N'Xã Thanh An', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25813, N'Phường Bến Cát', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25819, N'Xã Trừ Văn Thố', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25822, N'Xã Bàu Bàng', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25837, N'Phường Chánh Phú Hòa', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25840, N'Phường Long Nguyên', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25843, N'Phường Tây Nam', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25846, N'Phường Thới Hòa', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25849, N'Phường Hòa Lợi', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25858, N'Xã Phú Giáo', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25864, N'Xã Phước Thành', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25867, N'Xã An Long', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25882, N'Xã Phước Hòa', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25888, N'Phường Tân Uyên', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25891, N'Phường Tân Khánh', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25906, N'Xã Bắc Tân Uyên', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25909, N'Xã Thường Tân', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25912, N'Phường Vĩnh Tân', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25915, N'Phường Bình Cơ', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25920, N'Phường Tân Hiệp', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25942, N'Phường Dĩ An', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25945, N'Phường Tân Đông Hiệp', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25951, N'Phường Đông Hòa', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25966, N'Phường Lái Thiêu', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25969, N'Phường Thuận Giao', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25975, N'Phường An Phú', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25978, N'Phường Thuận An', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25987, N'Phường Bình Hòa', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26506, N'Phường Vũng Tàu', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26526, N'Phường Tam Thắng', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26536, N'Phường Rạch Dừa', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26542, N'Phường Phước Thắng', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26545, N'Xã Long Sơn', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26560, N'Phường Bà Rịa', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26566, N'Phường Long Hương', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26572, N'Phường Tam Long', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26575, N'Xã Ngãi Giao', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26584, N'Xã Xuân Sơn', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26590, N'Xã Bình Giã', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26596, N'Xã Châu Đức', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26608, N'Xã Kim Long', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26617, N'Xã Nghĩa Thành', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26620, N'Xã Hồ Tràm', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26632, N'Xã Xuyên Mộc', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26638, N'Xã Bàu Lâm', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26641, N'Xã Hòa Hội', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26647, N'Xã Hòa Hiệp', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26656, N'Xã Bình Châu', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26659, N'Xã Long Điền', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26662, N'Xã Long Hải', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26680, N'Xã Đất Đỏ', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26686, N'Xã Phước Hải', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26704, N'Phường Phú Mỹ', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26710, N'Phường Tân Hải', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26713, N'Phường Tân Phước', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26725, N'Phường Tân Thành', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26728, N'Xã Châu Pha', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26732, N'Đặc khu Côn Đảo', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26737, N'Phường Tân Định', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26740, N'Phường Sài Gòn', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26743, N'Phường Bến Thành', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26758, N'Phường Cầu Ông Lãnh', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26767, N'Phường An Phú Đông', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26773, N'Phường Thới An', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26782, N'Phường Tân Thới Hiệp', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26785, N'Phường Trung Mỹ Tây', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26791, N'Phường Đông Hưng Thuận', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26800, N'Phường Linh Xuân', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26803, N'Phường Tam Bình', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26809, N'Phường Hiệp Bình', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26824, N'Phường Thủ Đức', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26833, N'Phường Long Bình', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26842, N'Phường Tăng Nhơn Phú', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26848, N'Phường Phước Long', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26857, N'Phường Long Phước', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26860, N'Phường Long Trường', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26876, N'Phường An Nhơn', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26878, N'Phường An Hội Đông', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26882, N'Phường An Hội Tây', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26884, N'Phường Gò Vấp', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26890, N'Phường Hạnh Thông', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26898, N'Phường Thông Tây Hội', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26905, N'Phường Bình Lợi Trung', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26911, N'Phường Bình Quới', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26929, N'Phường Bình Thạnh', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26944, N'Phường Gia Định', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26956, N'Phường Thạnh Mỹ Tây', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26968, N'Phường Tân Sơn Nhất', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26977, N'Phường Tân Sơn Hòa', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26983, N'Phường Bảy Hiền', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (26995, N'Phường Tân Hòa', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27004, N'Phường Tân Bình', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27007, N'Phường Tân Sơn', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27013, N'Phường Tây Thạnh', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27019, N'Phường Tân Sơn Nhì', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27022, N'Phường Phú Thọ Hòa', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27028, N'Phường Phú Thạnh', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27031, N'Phường Tân Phú', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27043, N'Phường Đức Nhuận', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27058, N'Phường Cầu Kiệu', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27073, N'Phường Phú Nhuận', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27094, N'Phường An Khánh', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27097, N'Phường Bình Trưng', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27112, N'Phường Cát Lái', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27139, N'Phường Xuân Hòa', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27142, N'Phường Nhiêu Lộc', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27154, N'Phường Bàn Cờ', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27163, N'Phường Hòa Hưng', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27169, N'Phường Diên Hồng', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27190, N'Phường Vườn Lài', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27211, N'Phường Hòa Bình', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27226, N'Phường Phú Thọ', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27232, N'Phường Bình Thới', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27238, N'Phường Minh Phụng', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27259, N'Phường Xóm Chiếu', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27265, N'Phường Khánh Hội', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27286, N'Phường Vĩnh Hội', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27301, N'Phường Chợ Quán', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27316, N'Phường An Đông', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27343, N'Phường Chợ Lớn', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27349, N'Phường Phú Lâm', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27364, N'Phường Bình Phú', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27367, N'Phường Bình Tây', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27373, N'Phường Bình Tiên', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27418, N'Phường Chánh Hưng', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27424, N'Phường Bình Đông', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27427, N'Phường Phú Định', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27439, N'Phường Bình Hưng Hòa', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27442, N'Phường Bình Tân', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27448, N'Phường Bình Trị Đông', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27457, N'Phường Tân Tạo', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27460, N'Phường An Lạc', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27475, N'Phường Tân Hưng', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27478, N'Phường Tân Thuận', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27484, N'Phường Phú Thuận', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27487, N'Phường Tân Mỹ', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27496, N'Xã Tân An Hội', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27508, N'Xã An Nhơn Tây', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27511, N'Xã Nhuận Đức', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27526, N'Xã Thái Mỹ', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27541, N'Xã Phú Hòa Đông', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27544, N'Xã Bình Mỹ', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27553, N'Xã Củ Chi', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27559, N'Xã Hóc Môn', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27568, N'Xã Đông Thạnh', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27577, N'Xã Xuân Thới Sơn', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27592, N'Xã Bà Điểm', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27595, N'Xã Tân Nhựt', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27601, N'Xã Vĩnh Lộc', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27604, N'Xã Tân Vĩnh Lộc', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27610, N'Xã Bình Lợi', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27619, N'Xã Bình Hưng', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27628, N'Xã Hưng Long', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27637, N'Xã Bình Chánh', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27655, N'Xã Nhà Bè', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27658, N'Xã Hiệp Phước', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27664, N'Xã Cần Giờ', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27667, N'Xã Bình Khánh', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27673, N'Xã An Thới Đông', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27676, N'Xã Thạnh An', 79);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25459, N'Phường Tân Ninh', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25480, N'Phường Bình Minh', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25486, N'Xã Tân Biên', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25489, N'Xã Tân Lập', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25498, N'Xã Thạnh Bình', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25510, N'Xã Trà Vong', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25516, N'Xã Tân Châu', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25522, N'Xã Tân Đông', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25525, N'Xã Tân Hội', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25531, N'Xã Tân Hòa', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25534, N'Xã Tân Thành', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25549, N'Xã Tân Phú', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25552, N'Xã Dương Minh Châu', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25567, N'Phường Ninh Thạnh', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25573, N'Xã Cầu Khởi', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25579, N'Xã Lộc Ninh', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25585, N'Xã Châu Thành', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25588, N'Xã Hảo Đước  ', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25591, N'Xã Phước Vinh', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25606, N'Xã Hòa Hội', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25621, N'Xã Ninh Điền', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25630, N'Phường Long Hoa', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25633, N'Phường Thanh Điền', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25645, N'Phường Hòa Thành', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25654, N'Phường Gò Dầu', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25657, N'Xã Thạnh Đức', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25663, N'Xã Phước Thạnh', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25666, N'Xã Truông Mít', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25672, N'Phường Gia Lộc', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25681, N'Xã Bến Cầu', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25684, N'Xã Long Chữ', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25702, N'Xã Long Thuận', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25708, N'Phường Trảng Bàng', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25711, N'Xã Hưng Thuận', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25729, N'Xã Phước Chỉ', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (25732, N'Phường An Tịnh', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27694, N'Phường Long An', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27712, N'Phường Tân An', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27715, N'Phường Khánh Hậu ', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27721, N'Xã Tân Hưng', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27727, N'Xã Hưng Điền', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27736, N'Xã Vĩnh Thạnh', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27748, N'Xã Vĩnh Châu', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27757, N'Xã Vĩnh Hưng', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27763, N'Xã Khánh Hưng', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27775, N'Xã Tuyên Bình', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27787, N'Phường Kiến Tường', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27793, N'Xã Bình Hiệp', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27811, N'Xã Bình Hòa', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27817, N'Xã Tuyên Thạnh', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27823, N'Xã Mộc Hóa', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27826, N'Xã Tân Thạnh', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27838, N'Xã Nhơn Hòa Lập', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27841, N'Xã Hậu Thạnh', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27856, N'Xã Nhơn Ninh', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27865, N'Xã Thạnh Hóa', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27868, N'Xã Bình Thành', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27877, N'Xã Thạnh Phước', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27889, N'Xã Tân Tây', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27898, N'Xã Đông Thành', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27907, N'Xã Mỹ Quý', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27925, N'Xã Đức Huệ', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27931, N'Xã Hậu Nghĩa', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27937, N'Xã Đức Hòa', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27943, N'Xã An Ninh', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27952, N'Xã Hiệp Hòa', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27964, N'Xã Đức Lập', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27976, N'Xã Mỹ Hạnh', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27979, N'Xã Hòa Khánh', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27991, N'Xã Bến Lức', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (27994, N'Xã Thạnh Lợi', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28003, N'Xã Lương Hòa', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28015, N'Xã Bình Đức', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28018, N'Xã Mỹ Yên', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28036, N'Xã Thủ Thừa', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28051, N'Xã Mỹ Thạnh', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28066, N'Xã Mỹ An', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28072, N'Xã Tân Long', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28075, N'Xã Tân Trụ', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28087, N'Xã Nhựt Tảo', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28093, N'Xã Vàm Cỏ', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28108, N'Xã Cần Đước', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28114, N'Xã Rạch Kiến', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28126, N'Xã Long Cang', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28132, N'Xã Mỹ Lệ', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28138, N'Xã Tân Lân', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28144, N'Xã Long Hựu', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28159, N'Xã Cần Giuộc', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28165, N'Xã Phước Lý', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28177, N'Xã Mỹ Lộc', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28201, N'Xã Phước Vĩnh Tây', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28207, N'Xã Tân Tập', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28210, N'Xã Tầm Vu', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28222, N'Xã Vĩnh Công', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28225, N'Xã Thuận Mỹ', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28243, N'Xã An Lục Long', 80);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28249, N'Phường Đạo Thạnh', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28261, N'Phường Mỹ Tho', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28270, N'Phường Thới Sơn', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28273, N'Phường Mỹ Phong', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28285, N'Phường Trung An', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28297, N'Phường Long Thuận', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28306, N'Phường Gò Công', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28315, N'Phường Bình Xuân', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28321, N'Xã Tân Phước 1', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28327, N'Xã Tân Phước 2', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28336, N'Xã Hưng Thạnh', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28345, N'Xã Tân Phước 3', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28360, N'Xã Cái Bè', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28366, N'Xã Hậu Mỹ', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28378, N'Xã Mỹ Thiện', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28393, N'Xã Hội Cư', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28405, N'Xã Mỹ Đức Tây', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28414, N'Xã Mỹ Lợi', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28426, N'Xã Thanh Hưng', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28429, N'Xã An Hữu', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28435, N'Phường Mỹ Phước Tây', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28436, N'Phường Thanh Hòa', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28439, N'Phường Cai Lậy', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28444, N'Xã Thạnh Phú', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28456, N'Xã Mỹ Thành', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28468, N'Xã Tân Phú', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28471, N'Xã Bình Phú', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28477, N'Phường Nhị Quý', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28501, N'Xã Hiệp Đức', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28504, N'Xã Long Tiên', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28516, N'Xã Ngũ Hiệp', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28519, N'Xã Châu Thành', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28525, N'Xã Tân Hương', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28537, N'Xã Long Hưng', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28543, N'Xã Long Định', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28564, N'Xã Bình Trưng', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28576, N'Xã Vĩnh Kim', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28582, N'Xã Kim Sơn', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28594, N'Xã Chợ Gạo', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28603, N'Xã Mỹ Tịnh An', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28615, N'Xã Lương Hòa Lạc', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28627, N'Xã Tân Thuận Bình', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28633, N'Xã An Thạnh Thủy', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28648, N'Xã Bình Ninh', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28651, N'Xã Vĩnh Bình', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28660, N'Xã Đồng Sơn', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28663, N'Xã Phú Thành', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28678, N'Xã Vĩnh Hựu', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28687, N'Xã Long Bình', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28693, N'Xã Tân Thới', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28696, N'Xã Tân Phú Đông', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28702, N'Xã Tân Hòa', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28720, N'Xã Gia Thuận', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28723, N'Xã Tân Đông', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28729, N'Phường Sơn Qui', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28738, N'Xã Tân Điền', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28747, N'Xã Gò Công Đông', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29869, N'Phường Cao Lãnh', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29884, N'Phường Mỹ Ngãi', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29888, N'Phường Mỹ Trà', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29905, N'Phường Sa Đéc', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29926, N'Xã Tân Hồng', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29929, N'Xã Tân Hộ Cơ', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29938, N'Xã Tân Thành', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29944, N'Xã An Phước', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29954, N'Phường An Bình', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29955, N'Phường Hồng Ngự', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29971, N'Xã Thường Phước', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29978, N'Phường Thường Lạc', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29983, N'Xã Long Khánh', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29992, N'Xã Long Phú Thuận', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30001, N'Xã Tràm Chim', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30010, N'Xã Tam Nông', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30019, N'Xã An Hòa', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30025, N'Xã Phú Cường', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30028, N'Xã An Long', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30034, N'Xã Phú Thọ', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30037, N'Xã Tháp Mười', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30043, N'Xã Phương Thịnh', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30046, N'Xã Trường Xuân', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30055, N'Xã Mỹ Quí', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30061, N'Xã Đốc Binh Kiều', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30073, N'Xã Thanh Mỹ', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30076, N'Xã Mỹ Thọ', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30085, N'Xã Ba Sao', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30088, N'Xã Phong Mỹ', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30112, N'Xã Mỹ Hiệp', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30118, N'Xã Bình Hàng Trung', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30130, N'Xã Thanh Bình', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30154, N'Xã Tân Long', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30157, N'Xã Tân Thạnh', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30163, N'Xã Bình Thành', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30169, N'Xã Lấp Vò', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30178, N'Xã Mỹ An Hưng', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30184, N'Xã Tân Khánh Trung', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30208, N'Xã Hòa Long', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30214, N'Xã Tân Dương', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30226, N'Xã Lai Vung', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30235, N'Xã Phong Hòa', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30244, N'Xã Phú Hựu', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30253, N'Xã Tân Nhuận Đông', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30259, N'Xã Tân Phú Trung', 82);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28756, N'Phường Phú Khương', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28777, N'Phường An Hội', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28783, N'Phường Sơn Đông', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28789, N'Phường Bến Tre', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28807, N'Xã Giao Long', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28810, N'Xã Phú Túc', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28840, N'Xã Tân Phú', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28858, N'Phường Phú Tân', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28861, N'Xã Tiên Thủy', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28870, N'Xã Chợ Lách', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28879, N'Xã Phú Phụng', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28894, N'Xã Vĩnh Thành', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28901, N'Xã Hưng Khánh Trung', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28903, N'Xã Mỏ Cày', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28915, N'Xã Phước Mỹ Trung', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28921, N'Xã Tân Thành Bình', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28945, N'Xã Đồng Khởi', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28948, N'Xã Nhuận Phú Tân', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28957, N'Xã An Định', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28969, N'Xã Thành Thới', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28981, N'Xã Hương Mỹ', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28984, N'Xã Giồng Trôm', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28987, N'Xã Lương Hòa', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28993, N'Xã Lương Phú', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (28996, N'Xã Châu Hòa', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29020, N'Xã Phước Long', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29029, N'Xã Tân Hào', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29044, N'Xã Hưng Nhượng', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29050, N'Xã Bình Đại', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29062, N'Xã Phú Thuận', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29077, N'Xã Lộc Thuận', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29083, N'Xã Châu Hưng', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29089, N'Xã Thạnh Trị', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29104, N'Xã Thạnh Phước', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29107, N'Xã Thới Thuận', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29110, N'Xã Ba Tri', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29122, N'Xã Mỹ Chánh Hòa', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29125, N'Xã Bảo Thạnh', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29137, N'Xã Tân Xuân', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29143, N'Xã An Ngãi Trung', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29158, N'Xã An Hiệp', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29167, N'Xã Tân Thủy', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29182, N'Xã Thạnh Phú', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29191, N'Xã Quới Điền', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29194, N'Xã Đại Điền', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29221, N'Xã Thạnh Hải', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29224, N'Xã An Qui', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29227, N'Xã Thạnh Phong', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29242, N'Phường Trà Vinh', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29254, N'Phường Nguyệt Hóa', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29263, N'Phường Long Đức', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29266, N'Xã Càng Long', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29275, N'Xã An Trường', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29278, N'Xã Tân An', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29287, N'Xã Bình Phú', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29302, N'Xã Nhị Long', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29308, N'Xã Cầu Kè', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29317, N'Xã An Phú Tân', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29329, N'Xã Phong Thạnh', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29335, N'Xã Tam Ngãi', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29341, N'Xã Tiểu Cần', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29362, N'Xã Hùng Hòa', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29365, N'Xã Tập Ngãi', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29371, N'Xã Tân Hòa', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29374, N'Xã Châu Thành', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29386, N'Xã Song Lộc', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29398, N'Phường Hòa Thuận', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29407, N'Xã Hưng Mỹ', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29410, N'Xã Hòa Minh', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29413, N'Xã Long Hòa', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29416, N'Xã Cầu Ngang', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29419, N'Xã Mỹ Long', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29431, N'Xã Vinh Kim', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29446, N'Xã Nhị Trường', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29455, N'Xã Hiệp Mỹ', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29461, N'Xã Trà Cú', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29467, N'Xã Tập Sơn', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29476, N'Xã Lưu Nghiệp Anh', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29489, N'Xã Hàm Giang', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29491, N'Xã Đại An', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29497, N'Xã Đôn Châu', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29506, N'Xã Long Hiệp', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29512, N'Phường Duyên Hải', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29513, N'Xã Long Thành', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29516, N'Phường Trường Long Hòa', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29518, N'Xã Long Hữu', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29530, N'Xã Ngũ Lạc', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29533, N'Xã Long Vĩnh', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29536, N'Xã Đông Hải', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29551, N'Phường Long Châu', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29557, N'Phường Phước Hậu', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29566, N'Phường Tân Ngãi', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29584, N'Xã An Bình', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29590, N'Phường Thanh Đức', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29593, N'Phường Tân Hạnh', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29602, N'Xã Long Hồ', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29611, N'Xã Phú Quới', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29623, N'Xã Nhơn Phú', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29638, N'Xã Bình Phước', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29641, N'Xã Cái Nhum', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29653, N'Xã Tân Long Hội', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29659, N'Xã Trung Thành', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29668, N'Xã Quới An', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29677, N'Xã Quới Thiện', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29683, N'Xã Trung Hiệp', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29698, N'Xã Trung Ngãi', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29701, N'Xã Hiếu Phụng', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29713, N'Xã Hiếu Thành', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29719, N'Xã Tam Bình', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29728, N'Xã Cái Ngang', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29734, N'Xã Hòa Hiệp', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29740, N'Xã Song Phú', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29767, N'Xã Ngãi Tứ', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29770, N'Phường Cái Vồn', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29771, N'Phường Bình Minh', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29785, N'Xã Tân Lược', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29788, N'Xã Mỹ Thuận', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29800, N'Xã Tân Quới', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29812, N'Phường Đông Thành', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29821, N'Xã Trà Ôn', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29830, N'Xã Hòa Bình', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29836, N'Xã Trà Côn', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29845, N'Xã Vĩnh Xuân', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (29857, N'Xã Lục Sĩ Thành', 86);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30292, N'Phường Bình Đức', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30301, N'Phường Mỹ Thới', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30307, N'Phường Long Xuyên', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30313, N'Xã Mỹ Hòa Hưng', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30316, N'Phường Châu Đốc', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30325, N'Phường Vĩnh Tế', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30337, N'Xã An Phú', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30341, N'Xã Khánh Bình', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30346, N'Xã Nhơn Hội', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30352, N'Xã Phú Hữu', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30367, N'Xã Vĩnh Hậu', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30376, N'Phường Tân Châu', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30377, N'Phường Long Phú', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30385, N'Xã Vĩnh Xương', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30388, N'Xã Tân An', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30403, N'Xã Châu Phong', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30406, N'Xã Phú Tân', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30409, N'Xã Chợ Vàm', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30421, N'Xã Phú Lâm', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30430, N'Xã Hòa Lạc', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30436, N'Xã Phú An', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30445, N'Xã Bình Thạnh Đông', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30463, N'Xã Châu Phú', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30469, N'Xã Mỹ Đức', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30478, N'Xã Vĩnh Thạnh Trung', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30481, N'Xã Thạnh Mỹ Tây', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30487, N'Xã Bình Mỹ', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30502, N'Phường Thới Sơn', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30505, N'Phường Chi Lăng', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30520, N'Phường Tịnh Biên', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30526, N'Xã An Cư', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30538, N'Xã Núi Cấm', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30544, N'Xã Tri Tôn', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30547, N'Xã Ba Chúc', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30568, N'Xã Vĩnh Gia', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30577, N'Xã Ô Lâm', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30580, N'Xã Cô Tô', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30589, N'Xã An Châu', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30595, N'Xã Cần Đăng', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30604, N'Xã Vĩnh An', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30607, N'Xã Bình Hòa', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30619, N'Xã Vĩnh Hanh', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30628, N'Xã Chợ Mới', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30631, N'Xã Long Điền', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30643, N'Xã Cù Lao Giêng', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30658, N'Xã Nhơn Mỹ', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30664, N'Xã Long Kiến', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30673, N'Xã Hội An', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30682, N'Xã Thoại Sơn', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30685, N'Xã Phú Hòa', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30688, N'Xã Óc Eo', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30691, N'Xã Tây Phú', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30697, N'Xã Vĩnh Trạch', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30709, N'Xã Định Mỹ', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30742, N'Phường Rạch Giá', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30760, N'Phường Vĩnh Thông', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30766, N'Phường Tô Châu', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30769, N'Phường Hà Tiên', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30781, N'Xã Tiên Hải', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30787, N'Xã Kiên Lương', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30790, N'Xã Hòa Điền', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30793, N'Xã Vĩnh Điều', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30796, N'Xã Giang Thành', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30811, N'Xã Sơn Hải', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30814, N'Xã Hòn Nghệ', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30817, N'Xã Hòn Đất', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30823, N'Xã Bình Sơn', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30826, N'Xã Bình Giang', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30835, N'Xã Sơn Kiên', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30838, N'Xã Mỹ Thuận', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30850, N'Xã Tân Hiệp', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30856, N'Xã Tân Hội', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30874, N'Xã Thạnh Đông', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30880, N'Xã Châu Thành', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30886, N'Xã Thạnh Lộc', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30898, N'Xã Bình An', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30904, N'Xã Giồng Riềng', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30910, N'Xã Thạnh Hưng', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30928, N'Xã Ngọc Chúc', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30934, N'Xã Hòa Hưng', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30943, N'Xã Long Thạnh', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30949, N'Xã Hòa Thuận', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30952, N'Xã Gò Quao', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30958, N'Xã Định Hòa', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30970, N'Xã Vĩnh Hòa Hưng', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30982, N'Xã Vĩnh Tuy', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30985, N'Xã An Biên', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (30988, N'Xã Tây Yên', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31006, N'Xã Đông Thái', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31012, N'Xã Vĩnh Hòa', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31018, N'Xã An Minh', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31024, N'Xã Đông Hòa', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31027, N'Xã U Minh Thượng', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31031, N'Xã Tân Thạnh', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31036, N'Xã Đông Hưng', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31042, N'Xã Vân Khánh', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31051, N'Xã Vĩnh Phong', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31064, N'Xã Vĩnh Bình', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31069, N'Xã Vĩnh Thuận', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31078, N'Đặc khu Phú Quốc', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31105, N'Đặc khu Thổ Châu', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31108, N'Đặc khu Kiên Hải', 91);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31120, N'Phường Cái Khế', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31135, N'Phường Ninh Kiều', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31147, N'Phường Tân An', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31150, N'Phường An Bình', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31153, N'Phường Ô Môn', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31157, N'Phường Thới Long', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31162, N'Phường Phước Thới', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31168, N'Phường Bình Thủy', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31174, N'Phường Thới An Đông', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31183, N'Phường Long Tuyền', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31186, N'Phường Cái Răng', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31201, N'Phường Hưng Phú', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31207, N'Phường Thốt Nốt', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31213, N'Phường Tân Lộc', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31217, N'Phường Trung Nhứt', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31228, N'Phường Thuận Hưng', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31231, N'Xã Thạnh An', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31232, N'Xã Vĩnh Thạnh', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31237, N'Xã Vĩnh Trinh', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31246, N'Xã Thạnh Quới', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31249, N'Xã Thạnh Phú', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31255, N'Xã Trung Hưng', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31258, N'Xã Thới Lai', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31261, N'Xã Cờ Đỏ', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31264, N'Xã Thới Hưng', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31273, N'Xã Đông Hiệp', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31282, N'Xã Đông Thuận', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31288, N'Xã Trường Thành', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31294, N'Xã Trường Xuân', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31299, N'Xã Phong Điền', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31309, N'Xã Trường Long', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31315, N'Xã Nhơn Ái', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31321, N'Phường Vị Thanh', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31333, N'Phường Vị Tân', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31338, N'Xã Hỏa Lựu', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31340, N'Phường Ngã Bảy', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31342, N'Xã Tân Hòa', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31348, N'Xã Trường Long Tây', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31360, N'Xã Thạnh Xuân', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31366, N'Xã Châu Thành', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31369, N'Xã Đông Phước', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31378, N'Xã Phú Hữu', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31393, N'Xã Hòa An', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31396, N'Xã Hiệp Hưng', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31399, N'Xã Tân Bình', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31408, N'Xã Thạnh Hòa', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31411, N'Phường Đại Thành', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31420, N'Xã Phụng Hiệp', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31426, N'Xã Phương Bình', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31432, N'Xã Tân Phước Hưng', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31441, N'Xã Vị Thủy', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31453, N'Xã Vĩnh Thuận Đông', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31459, N'Xã  Vĩnh Tường', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31465, N'Xã Vị Thanh 1', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31471, N'Phường Long Mỹ  ', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31473, N'Phường Long Bình', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31480, N'Phường Long Phú 1', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31489, N'Xã Vĩnh Viễn', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31492, N'Xã Lương Tâm', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31495, N'Xã Xà Phiên', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31507, N'Phường Sóc Trăng', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31510, N'Phường Phú Lợi', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31528, N'Xã Kế Sách', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31531, N'Xã An Lạc Thôn', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31537, N'Xã Phong Nẫm', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31540, N'Xã Thới An Hội', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31552, N'Xã Nhơn Mỹ', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31561, N'Xã Đại Hải', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31567, N'Xã Mỹ Tú', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31569, N'Xã Phú Tâm', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31570, N'Xã Hồ Đắc Kiện', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31579, N'Xã Long Hưng', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31582, N'Xã Thuận Hòa', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31591, N'Xã Mỹ Hương', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31594, N'Xã An Ninh', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31603, N'Xã Mỹ Phước', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31615, N'Xã An Thạnh', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31633, N'Xã Cù Lao Dung', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31639, N'Xã Long Phú', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31645, N'Xã Đại Ngãi', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31654, N'Xã Trường Khánh', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31666, N'Xã Tân Thạnh', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31673, N'Xã Trần Đề', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31675, N'Xã Liêu Tú', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31679, N'Xã Lịch Hội Thượng', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31684, N'Phường Mỹ Xuyên', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31687, N'Xã Tài Văn', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31699, N'Xã Thạnh Thới An', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31708, N'Xã Nhu Gia', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31717, N'Xã Hòa Tú', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31723, N'Xã Ngọc Tố', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31726, N'Xã Gia Hòa', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31732, N'Phường Ngã Năm', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31741, N'Xã Tân Long', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31753, N'Phường Mỹ Quới', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31756, N'Xã Phú Lộc', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31759, N'Xã Lâm Tân', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31777, N'Xã Vĩnh Lợi', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31783, N'Phường Vĩnh Châu', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31789, N'Phường Khánh Hòa', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31795, N'Xã Vĩnh Hải', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31804, N'Phường Vĩnh Phước', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31810, N'Xã Lai Hòa', 92);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31825, N'Phường Bạc Liêu', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31834, N'Phường Vĩnh Trạch', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31840, N'Phường Hiệp Thành', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31843, N'Xã Hồng Dân', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31849, N'Xã Ninh Quới', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31858, N'Xã Vĩnh Lộc', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31864, N'Xã Ninh Thạnh Lợi', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31867, N'Xã Phước Long', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31876, N'Xã Vĩnh Phước', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31882, N'Xã Vĩnh Thanh', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31885, N'Xã Phong Hiệp', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31891, N'Xã Hòa Bình', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31894, N'Xã Châu Thới', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31900, N'Xã Vĩnh Lợi', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31906, N'Xã Hưng Hội', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31918, N'Xã Vĩnh Mỹ', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31927, N'Xã Vĩnh Hậu  ', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31942, N'Phường Giá Rai', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31951, N'Phường Láng Tròn', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31957, N'Xã Phong Thạnh', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31972, N'Xã Gành Hào', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31975, N'Xã Đông Hải', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31985, N'Xã Long Điền', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31988, N'Xã An Trạch', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (31993, N'Xã Định Thành', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32002, N'Phường An Xuyên', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32014, N'Phường Lý Văn Lâm', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32025, N'Phường Tân Thành', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32041, N'Phường Hòa Thành', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32044, N'Xã Nguyễn Phích', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32047, N'Xã U Minh', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32059, N'Xã Khánh An', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32062, N'Xã Khánh Lâm', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32065, N'Xã Thới Bình', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32069, N'Xã Biển Bạch', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32071, N'Xã Trí Phải', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32083, N'Xã Tân Lộc', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32092, N'Xã Hồ Thị Kỷ', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32095, N'Xã Trần Văn Thời', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32098, N'Xã Sông Đốc', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32104, N'Xã Đá Bạc', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32110, N'Xã Khánh Bình', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32119, N'Xã Khánh Hưng', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32128, N'Xã Cái Nước', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32134, N'Xã Lương Thế Trân', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32137, N'Xã Tân Hưng', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32140, N'Xã Hưng Mỹ', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32152, N'Xã Đầm Dơi', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32155, N'Xã Tạ An Khương', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32161, N'Xã Trần Phán', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32167, N'Xã Tân Thuận', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32182, N'Xã Quách Phẩm', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32185, N'Xã Thanh Tùng', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32188, N'Xã Tân Tiến', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32191, N'Xã Năm Căn', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32201, N'Xã Đất Mới', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32206, N'Xã Tam Giang', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32212, N'Xã Cái Đôi Vàm', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32214, N'Xã Phú Mỹ', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32218, N'Xã Phú Tân', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32227, N'Xã Nguyễn Việt Khái', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32236, N'Xã Tân Ân', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32244, N'Xã Phan Ngọc Hiển', 96);
INSERT INTO Xa (XaId, TenXa, TinhId) VALUES (32248, N'Xã Đất Mũi', 96);
GO

/* =========================
   DANH MỤC DÂN TỘC – TÔN GIÁO
   ========================= */
CREATE TABLE DanToc (
    DanTocId INT IDENTITY PRIMARY KEY,
    TenDanToc NVARCHAR(100)
);
GO
INSERT INTO DanToc (TenDanToc) VALUES
(N'Kinh'),
(N'Tày'),
(N'Thái'),
(N'Mường'),
(N'Hoa'),
(N'Khơ-me'),
(N'Nùng'),
(N'HMông'),
(N'Dao'),
(N'Gia-rai'),
(N'Ê-đê'),
(N'Ba-na'),
(N'Sán Chay'),
(N'Chăm'),
(N'Xơ-đăng'),
(N'Sán Dìu'),
(N'Hrê'),
(N'Cơ-ho'),
(N'Ra-glai'),
(N'Mnông'),
(N'Thổ'),
(N'Xtiêng'),
(N'Khơ-mú'),
(N'Bru-Vân Kiều'),
(N'Giáy'),
(N'Cơ-tu'),
(N'Gié-Triêng'),
(N'Ta-ôi'),
(N'Mạ'),
(N'Co'),
(N'Chơ-ro'),
(N'Hà Nhì'),
(N'Xinh-mun'),
(N'Chu-ru'),
(N'Lào'),
(N'La-chí'),
(N'Phù Lá'),
(N'La Hủ'),
(N'Kháng'),
(N'Lự'),
(N'Pà Thẻn'),
(N'Lô Lô'),
(N'Chứt'),
(N'Mảng'),
(N'Cờ Lao'),
(N'Bố Y'),
(N'La Ha'),
(N'Cống'),
(N'Ngái'),
(N'Si La'),
(N'Pu Péo'),
(N'Brâu'),
(N'Rơ-măm'),
(N'Ơ-đu');
GO


CREATE TABLE TonGiao (
    TonGiaoId INT IDENTITY PRIMARY KEY,
    TenTonGiao NVARCHAR(100)
);
GO
INSERT INTO TonGiao (TenTonGiao) VALUES
(N'Không'),
(N'Phật giáo'),
(N'Công giáo'),
(N'Tin lành'),
(N'Cao đài'),
(N'Phật giáo Hòa Hảo'),
(N'Hồi giáo'),
(N'Tôn giáo Baha''i'),
(N'Tịnh độ Cư sỹ Phật hội'),
(N'Cơ đốc Phục lâm'),
(N'Phật giáo Tứ Ân Hiếu Nghĩa'),
(N'Minh Sư đạo'),
(N'Minh Lý đạo – Tam Tông Miếu'),
(N'Bà-la-môn giáo'),
(N'Mặc môn'),
(N'Phật giáo Hiếu Nghĩa Tà Lơn'),
(N'Bửu Sơn Kỳ Hương');
GO


/* =========================
   DANH MỤC CHỨC DANH – CẤP BẬC
   ========================= */
CREATE TABLE ChucVu (
    ChucVuId INT IDENTITY PRIMARY KEY,
    TenChucVu NVARCHAR(100)
);
GO
INSERT INTO ChucVu (TenChucVu) VALUES
(N'Không'),

(N'Giám đốc'),
(N'Phó Giám đốc'),

(N'Chánh Văn phòng'),
(N'Phó Chánh Văn phòng'),

(N'Viện trưởng'),
(N'Phó Viện trưởng'),

(N'Trưởng phòng'),
(N'Phó Trưởng phòng'),

(N'Trung đội trưởng'),
(N'Phó Trung đội trưởng'),

(N'Tiểu đội trưởng'),
(N'Phó Tiểu đội trưởng');
GO

CREATE TABLE CapBac (
    CapBacId INT IDENTITY PRIMARY KEY,
    TenCapBac NVARCHAR(100)
);
GO
INSERT INTO CapBac (TenCapBac) VALUES
(N'Đại tướng'),
(N'Thượng tướng'),
(N'Trung tướng'),
(N'Thiếu tướng'),
(N'Đại tá'),
(N'Thượng tá'),
(N'Trung tá'),
(N'Thiếu tá'),
(N'Đại úy'),
(N'Thượng úy'),
(N'Trung úy'),
(N'Thiếu úy'),
(N'Thượng sĩ'),
(N'Trung sĩ'),
(N'Hạ sĩ'),
(N'Binh nhất'),
(N'Binh nhì');
GO


CREATE TABLE ChucDanh (
    ChucDanhId INT IDENTITY PRIMARY KEY,
    TenChucDanh NVARCHAR(100)
);
GO

/*TODO*/

/* =========================
   DANH MỤC TRÌNH ĐỘ
   ========================= */
CREATE TABLE TrinhDoChuyenMon (
    TrinhDoCMId INT IDENTITY PRIMARY KEY,
    TenTrinhDo NVARCHAR(100)
);
GO
INSERT INTO TrinhDoChuyenMon (TenTrinhDo) VALUES
(N'Sơ cấp'),
(N'Trung cấp'),
(N'Cao đẳng'),
(N'Đại học'),
(N'Thạc sĩ'),
(N'Tiến sĩ');
GO

CREATE TABLE TrinhDoLLCT (
    TrinhDoLLCTId INT IDENTITY PRIMARY KEY,
    TenTrinhDo NVARCHAR(100)
);
GO
INSERT INTO TrinhDoLLCT (TenTrinhDo) VALUES
(N'Sơ cấp'),
(N'Trung cấp'),
(N'Cao cấp');
GO

CREATE TABLE HocHam (
    HocHamId INT IDENTITY PRIMARY KEY,
    TenHocHam NVARCHAR(100)
);
GO
INSERT INTO HocHam (TenHocHam) VALUES
(N'Cử nhân'),
(N'Thạc sĩ'),
(N'Tiến sĩ'),
(N'Tiến sĩ Khoa học');
GO

CREATE TABLE HocVi (
    HocViId INT IDENTITY PRIMARY KEY,
    TenHocVi NVARCHAR(100)
);
GO
INSERT INTO HocVi (TenHocVi) VALUES
(N'Không'),
(N'Phó giáo sư'),
(N'Giáo sư');
GO

/* =========================
   DANH MỤC NGHIÊN CỨU
   ========================= */
CREATE TABLE LinhVuc (
    LinhVucId INT IDENTITY PRIMARY KEY,
    TenLinhVuc NVARCHAR(200)
);
GO
/* TODO */

CREATE TABLE VaiTroDeTai (
    VaiTroId INT IDENTITY PRIMARY KEY,
    TenVaiTro NVARCHAR(50) -- Nhóm trưởng, Thành viên
);
GO
INSERT INTO VaiTroDeTai (TenVaiTro) VALUES
(N'Nhóm trưởng'),
(N'Thành viên');
GO

CREATE TABLE TrangThaiDeTai (
    TrangThaiId INT IDENTITY PRIMARY KEY,
    TenTrangThai NVARCHAR(100)
);
GO
INSERT INTO TrangThaiDeTai (TenTrangThai) VALUES
(N'Mới đăng ký'),
(N'Đang thực hiện'),
(N'Đã nộp bản mềm'),
(N'Đã nộp bản cứng'),
(N'Đã rà quét đạo văn'),
(N'Đạt yêu cầu'),
(N'Không đạt yêu cầu'),
(N'Đã chấm điểm'),
(N'Đã xếp giải');
GO

CREATE TABLE GiaiThuong (
    GiaiId INT IDENTITY PRIMARY KEY,
    TenGiai NVARCHAR(50) -- Nhất, Nhì, Ba, Khuyến khích
);
GO
INSERT INTO GiaiThuong (TenGiai) VALUES
(N'Nhất'),
(N'Nhì'),
(N'Ba'),
(N'Khuyến khích');
GO

CREATE TABLE DonViCongTac (
    MaDV INT IDENTITY PRIMARY KEY,
    TenDV NVARCHAR(50)
);
GO
-- TODO: THÊM CÁC ĐƠN VỊ

/* =========================
   SINH VIÊN (36)
   ========================= */
CREATE TABLE SinhVien (
    MaSV NVARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(100),
    GioiTinh NVARCHAR(10),
    NgaySinh DATE,
    TinhId INT,
    XaId INT,
    DanTocId INT,
    TonGiaoId INT,
    SDT NVARCHAR(20),
    Lop NVARCHAR(50),
    ChucVuId INT,
    Nganh NVARCHAR(100),
    ChuyenNganh NVARCHAR(100),

    FOREIGN KEY (TinhId) REFERENCES Tinh(TinhId),
    FOREIGN KEY (XaId) REFERENCES Xa(XaId),
    FOREIGN KEY (DanTocId) REFERENCES DanToc(DanTocId),
    FOREIGN KEY (TonGiaoId) REFERENCES TonGiao(TonGiaoId),
    FOREIGN KEY (ChucVuId) REFERENCES ChucVu(ChucVuId)
);
GO

/* =========================
   GIẢNG VIÊN (37)
   ========================= */
CREATE TABLE GiangVien (
    MaCB NVARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(100),
    GioiTinh NVARCHAR(10),
    NgaySinh DATE,
    TinhId INT,
    XaId INT,
    DanTocId INT,
    TonGiaoId INT,
    SDT NVARCHAR(20),
    TrinhDoCMId INT,
    TrinhDoLLCTId INT,
    MaDV INT,
    ChucVuId INT,
    CapBacId INT,
    HeSoLuong FLOAT,
    ChucDanhId INT,
    HocHamId INT,
    HocViId INT,
    LinhVucChuyenMon NVARCHAR(200),

    FOREIGN KEY (TinhId) REFERENCES Tinh(TinhId),
    FOREIGN KEY (XaId) REFERENCES Xa(XaId),
    FOREIGN KEY (DanTocId) REFERENCES DanToc(DanTocId),
    FOREIGN KEY (TonGiaoId) REFERENCES TonGiao(TonGiaoId),
    FOREIGN KEY (TrinhDoCMId) REFERENCES TrinhDoChuyenMon(TrinhDoCMId),
    FOREIGN KEY (TrinhDoLLCTId) REFERENCES TrinhDoLLCT(TrinhDoLLCTId),
    FOREIGN KEY (MaDV) REFERENCES DonViCongTac(MaDV),
    FOREIGN KEY (ChucVuId) REFERENCES ChucVu(ChucVuId),
    FOREIGN KEY (CapBacId) REFERENCES CapBac(CapBacId),
    FOREIGN KEY (ChucDanhId) REFERENCES ChucDanh(ChucDanhId),
    FOREIGN KEY (HocHamId) REFERENCES HocHam(HocHamId),
    FOREIGN KEY (HocViId) REFERENCES HocVi(HocViId)
);
GO

/* =========================
   ĐỀ TÀI NCKH (38)
   ========================= */
CREATE TABLE DeTai (
    MaDT NVARCHAR(20) PRIMARY KEY,
    TenDT NVARCHAR(200),
    LinhVucId INT,
    MaGVHuongDan NVARCHAR(20),
    ThoiGianDuKien DATE,
    TrangThaiId INT,

    FOREIGN KEY (LinhVucId) REFERENCES LinhVuc(LinhVucId),
    FOREIGN KEY (MaGVHuongDan) REFERENCES GiangVien(MaCB),
    FOREIGN KEY (TrangThaiId) REFERENCES TrangThaiDeTai(TrangThaiId)
);
GO

CREATE TABLE DeTai_SinhVien (
    MaDT NVARCHAR(20),
    MaSV NVARCHAR(20),
    VaiTroId INT,

    PRIMARY KEY (MaDT, MaSV),
    FOREIGN KEY (MaDT) REFERENCES DeTai(MaDT),
    FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV),
    FOREIGN KEY (VaiTroId) REFERENCES VaiTroDeTai(VaiTroId)
);
GO

/* =========================
   CHUYÊN ĐỀ NCKH (39)
   ========================= */
CREATE TABLE ChuyenDe (
    MaCD NVARCHAR(20) PRIMARY KEY,
    TenCD NVARCHAR(200),
    MaSV NVARCHAR(20),
    LinhVucId INT,

    FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV),
    FOREIGN KEY (LinhVucId) REFERENCES LinhVuc(LinhVucId)
);
GO

/* =========================
   NỘP SẢN PHẨM (40–41)
   ========================= */
CREATE TABLE NopSanPham (
    Id INT IDENTITY PRIMARY KEY,
    MaSo NVARCHAR(20),
    Loai NVARCHAR(10), -- DT / CD
    TrangThaiNop NVARCHAR(100),
    NguoiNop NVARCHAR(20),
    NgayNop DATE
);
GO

/* =========================
   RÀ QUÉT ĐẠO VĂN (42)
   ========================= */
CREATE TABLE DaoVan (
    Id INT IDENTITY PRIMARY KEY,
    MaDT NVARCHAR(20),
    LanQuet INT,
    TyLeTrungLap FLOAT,
    KetLuan NVARCHAR(50),

    FOREIGN KEY (MaDT) REFERENCES DeTai(MaDT)
);
GO

/* =========================
   HỘI ĐỒNG CHẤM (43)
   ========================= */
CREATE TABLE HoiDong (
    MaHD INT IDENTITY PRIMARY KEY,
    NgayCham DATE
);
GO

CREATE TABLE HoiDong_ThanhVien (
    MaHD INT,
    MaCB NVARCHAR(20),
    VaiTroHoiDong NVARCHAR(50),

    PRIMARY KEY (MaHD, MaCB),
    FOREIGN KEY (MaHD) REFERENCES HoiDong(MaHD),
    FOREIGN KEY (MaCB) REFERENCES GiangVien(MaCB)
);
GO

CREATE TABLE HoiDong_DeTai (
    MaHD INT,
    MaDT NVARCHAR(20),

    PRIMARY KEY (MaHD, MaDT),
    FOREIGN KEY (MaHD) REFERENCES HoiDong(MaHD),
    FOREIGN KEY (MaDT) REFERENCES DeTai(MaDT)
);
GO

/* =========================
   CHẤM ĐIỂM (44–45)
   ========================= */
CREATE TABLE PhieuCham (
    Id INT IDENTITY PRIMARY KEY,
    MaSo NVARCHAR(20),
    Loai NVARCHAR(10), -- DT / CD
    MaCB NVARCHAR(20),
    VaiTroHoiDong NVARCHAR(50),
    Diem FLOAT,

    FOREIGN KEY (MaCB) REFERENCES GiangVien(MaCB)
);
GO

/* =========================
   KẾT QUẢ – XẾP GIẢI (46–47)
   ========================= */
CREATE TABLE KetQua (
    MaSo NVARCHAR(20) PRIMARY KEY,
    Loai NVARCHAR(10),
    DiemTrungBinh FLOAT,
    GiaiId INT,

    FOREIGN KEY (GiaiId) REFERENCES GiaiThuong(GiaiId)
);
GO
