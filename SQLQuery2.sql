use ScheduleManagement
go

create table PhongDaoTao(
	MaNV nchar(20) not null primary key,
	hoten nvarchar(50)
);

create table NganhHoc(
	MaNganh nchar(20) not null primary key,
	TenNganh nvarchar(50)
);

select * from NganhHoc

create table Khoa(
	MaKhoa nchar(20) not null primary key,
	TenKhoa nvarchar(50)
);

select * from Khoa

create table PhongHoc(
	MaPhongHoc nchar(20) not null primary key,
	MaKhoa nchar(20),
	SoCho int,
	LoaiPhong int,
	TinhTrang int

	constraint fk_makhoa foreign key (MaKhoa) references Khoa(MaKhoa)
);

select * from PhongHoc

create table GiangVien(
	MaGiangVien nchar(20) not null primary key,
	MaKhoa nchar(20),
	TenGiangVien nvarchar(50),
	BangCap nvarchar(50)

	constraint fk_makhoa_GiangVien foreign key (MaKhoa) references Khoa(MaKhoa)
);

select * from GiangVien


create table LopHoc(
	MaLop nchar(20) not null primary key,
	MaNganh nchar(20),
	TenLop nvarchar(20),
	MaGiangVien nchar(20),
	NamVaoTruong datetime

	constraint fk_maNganh_LopHoc foreign key (MaNganh) references NganhHoc(MaNganh),
	constraint fk_maGiangVien_LopHoc foreign key (MaGiangVien) references GiangVien(MaGiangVien)
);

select * from LopHoc


create table SinhVien(
	MaSV nchar(20) not null primary key,
	MaLop nchar(20),
	HoTen nvarchar(50),
	TinhTrang int

	constraint fk_maLop_SinhVien foreign key (MaLop) references LopHoc(MaLop)
);

select * from SinhVien

create table HocPhan (
	MaHocPhan nchar(20) not null primary key,
	MaKhoa nchar(20),
	TenHocPhan nvarchar(50),
	TinChi int, 
	LoaiHocPhan int

	constraint fk_makhoa_HocPhan foreign key (MaKhoa) references Khoa(MaKhoa)
);

select * from HocPhan

create table LopHocPhan(
	MaLopHocPhan nchar(20) not null primary key,
	MaHocPhan nchar(20),
	SoHocSinh int,
	MaLop nchar(20)

	CONSTRAINT FK_MaLop_LopHocPhan FOREIGN KEY (MaLop) REFERENCES LopHoc (MaLop)
);

select * from LopHocPhan

create table HocPhanTheoNganh(
	MaHocPhanTheoNganh nchar(20) not null primary key,
	MaNganh nchar(20),
	KyHoc int,
	NamHoc int

	constraint fk_maNganh_HPTN foreign key (MaNganh) references NganhHoc(MaNganh)
);

select * from HocPhanTheoNganh

create table ChiTietHPTheoNganh(
	MaChiTiet nchar(20) not null primary key,
	MaHocPhanTheoNganh nchar(20),
	MaHocPhan nchar(20),
	BatBuoc int

	constraint fk_maHPTN_ChiTietHPTN foreign key (MaHocPhanTheoNganh) references HocPhanTheoNganh(MaHocPhanTheoNganh),
	constraint fk_maHocPhan_ChiTietHPTN foreign key (MaHocPhan) references HocPhan(MaHocPhan)
);

select * from ChiTietHPTheoNganh

create table Lich(
	MaLich nchar(20) not null primary key,
	MaLopHocPhan nchar(20),
	MaGiangVien nchar(20),
	MaPhongHoc nchar(20),
	ThoiGian datetime

	constraint fk_maLopHocPhan_Lich foreign key (MaLopHocPhan) references LopHocPhan(MaLopHocPhan),
	constraint fk_maGiangVien_Lich foreign key (MaGiangVien) references GiangVien(MaGiangVien),
	constraint fk_maPhongHoc foreign key (MaPhongHoc) references PhongHoc(MaPhongHoc)
);

create table KetQua (
	MaKetQua nchar(20) not null primary key,
	MaSV nchar(20),
	Ky int,
	DiemTongKet4 float,
	DiemTongKet10 float

	constraint fk_maSV_KetQua foreign key (MaSV) references SinhVien(MaSV)
);

create table ChiTietQuaTrinh(
	MaChiTiet nchar(20) not null primary key,
	MaLopHocPhan nchar(20),
	MaKetQua nchar(20),
	DiemHS1 float,
	DiemHS2 float,
	TinhTrang int

	constraint fk_maLopHocPhan_ChiTietQuaTrinh foreign key (MaLopHocPhan) references LopHocPhan(MaLopHocPhan),
	constraint fk_maKetQua_ChiTietQuaTrinh foreign key (MaKetQua) references KetQua(MaKetQua)
);

create table DiemDanh(
	MaDiemDanh nchar(20) not null primary key,
	MaChiTiet nchar(20),
	CoPhep int default 0,
	ThoiGian datetime

	constraint fk_maChiTiet_DiemDanh foreign key (MaChiTiet) references ChiTietQuaTrinh(MaChiTiet)
);

create table LopThi(
	MaLopThi nchar(20) not null primary key,
	MaLopHocPhan nchar(20),
	MaPhongHoc nchar(20),
	ThoiGian datetime,
	MaGiangVien1 nchar(20),
	MaGiangVien2 nchar(20)

	constraint fk_maLopHocPhan_LopThi foreign key (MaLopHocPhan) references LopHocPhan(MaLopHocPhan),
	constraint fk_maPhong_LopThi foreign key (MaPhongHoc) references PhongHoc(MaPhongHoc),
	constraint fk_maGiangVien1_LopThi foreign key (MaGiangVien1) references GiangVien(MaGiangVien),
	constraint fk_maGiangVien2_LopThi foreign key (MaGiangVien2) references GiangVien(MaGiangVien)
);

create table Account(
	username nchar(20),
	password nchar(20),
	role int

	constraint fk_username_PhongDaoTao foreign key (username) references PhongDaoTao(MaNV),
	constraint fk_username_SinhVien foreign key (username) references SinhVien(MaSV),
	constraint fk_username_GiangVien foreign key (username) references GiangVien(MaGiangVien)
);	