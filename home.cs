@import url(../timezone/css/typography.css);
* {
  box-sizing: border-box;
  margin: 0;
}
body {
  font-family: "Open Sans", sans-serif;
  font-weight: 400;
  font-size: 14px;
  line-height: 20px;
}
.container {
  width: 100%;
  max-width: 1920px;
  margin: 0 auto;
  border-left: 1px solid #f6f6f6;
  border-right: 1px solid #f6f6f6;
}
img {
  max-width: 100%;
  display: inline-block;
  height: auto;
}
.nav-head {
  background: #f6f6f6;
}
.nav-bar {
  display: flex;
  align-items: center;
  justify-content: space-between;
  color: #242424;
  padding: 8px 16px;
}
.nav-head-section {
  display: flex;
  gap: 5px;
  align-items: center;
}
.nav-head-section span {
  font-size: 12px;
}
.col-sm {
  position: relative;
  width: 100%;
  display: flex;
  align-items: center;
  justify-content: center;
  padding-left: 20px;
  padding-right: 20px;
}
.truck-icon:before {
  content: "\f48b";
  font-family: 'fontAwesome';
}
.mobile-icon:before {
  content: "\f3ce";
  font-family: 'fontAwesome';
}
.arrow-icon:before {
  content: "\f363";
  font-family: 'fontAwesome';
}
.nav-section {
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding: 30px 50px;
  position: relative;
  transition: padding 0.5s;
}
.timezone-logo {
  padding: 0 20px;
}
.timezone-logo img {
  width: 100%;
  max-width: 55px;
  width: fit-content;
}
.timezone-menu {
  display: flex;
  align-items: center;
  list-style: none;
  position: relative;
}
.timezone-menu a {
  text-decoration: none;
  color: #242424;
  font-size: 16px;
  line-height: 10px;
  cursor: pointer;
  font-family: "Open Sans", sans-serif;
  font-weight: 500;
  padding: 16px 15px;
}
.timezone-menu a:hover {
  padding: 16px 15px;
  background: #80808017;
}
.nav-category {
  display: none;
}
.navigation-col:hover .nav-category {
  display: block;
}
.active {
  display: block;
}
li.navigation-col {
  padding-bottom: 30px;
  list-style: none;
  padding-top: 30px;
}
ul.nav-category li a {
  font-size: 15px;
}
.account.account-active {
  display: block;
}
.menu-section {
  display: flex;
  align-items: center;
  line-height: 1px;
}
ul.nav-category {
  list-style: none;
  border: 1px solid #f6f6f6;
  padding-left: 0;
  box-shadow: 0 0 8px rgba(0, 0, 0, 0.3);
  position: absolute;
  z-index: 2;
  background: #ffffff;
  top: 80%;
  width: 100%;
  max-width: 18%;
  transform: translateX(-50%);
  margin-left: 30px;
  padding-top: 15px;
}
ul.nav-category:before {
  content: "\f0d8";
  font-family: fontAWesome;
  color: #ffffff;
  position: absolute;
  top: -2px;
  left: 50%;
  font-size: 45px;
  z-index: 1;
  transform: translateX(-50%);
  border-color: transparent;
  border-width: 0 16px 16px 16px;
  filter: drop-shadow(0 0 0.5rem rgba(0, 0, 0, 0.3));
}
ul.nav-category:after {
  content: "";
  position: absolute;
  top: 0;
  left: 0;
  right: 0;
  height: 1rem;
  background: #ffffff;
  z-index: 11;
}
ul.nav-category a:hover {
  color: #000000;
  background: none;
}
.nav-col {
  display: none;
  background: #f6f6f6;
}
ul.nav-col {
  list-style: none;
  padding: 16px;
}
.nav-col li a {
  padding: 4px 16px;
}
ul.nav-sub {
  background: #E6E6E6;
}
.plus:after {
  content: "\2b";
  font-family: fontAwesome;
  position: absolute;
  right: 10px;
}
ul.main-menu {
  display: flex;
  align-items: center;
  padding-left: 0;
}
.info-note:before {
  content: "\f06a";
  font-family: fontAwesome;
}
.nav-menu {
  display: flex;
  list-style: none;
  text-transform: uppercase;
  padding: 0 20px;
}
.nav-menu a {
  text-decoration: none;
  color: #242424;
  padding: 16px 16px;
  display: flex;
  align-items: center;
  font-size: 18px;
  line-height: 22px;
  font-family: "Open Sans", sans-serif;
  font-weight: 500;
}
.nav-menu a:hover {
  background-color: #80808017;
}
.minus:after {
  content: "\f068";
  font-family: fontAwesome;
}
a.sale {
  color: #d41217;
}
.sub-timezone-nav a {
  padding: 0;
}
.cart-icon:after {
  content: "\f07a";
  font-family: 'fontAwesome';
}
.product-icon:before {
  content: "\f553";
  font-family: 'fontAwesome';
}
.row-item {
  background: #ffffff;
  border: 1px solid #E6E6E6;
  padding: 4px;
  margin-right: 10px;
  cursor: pointer;
}
.close-btn:before {
  content: "\f00d";
  font-family: 'fontAwesome';
}
.timezone-icons {
  display: flex;
  align-items: center;
  padding: 7px;
}
.timezone-icons a {
  text-decoration: none;
  margin-right: 4px;
}
.search-icon:before {
  content: "\f002";
  font-family: 'fontAwesome';
  font-size: 14px;
}
.like-icon:before {
  content: "\f004";
  font-family: 'fontAwesome';
  font-size: 14px;
}
.profile-icon:before {
  content: "\f007";
  font-family: 'fontAwesome';
  font-size: 15px;
}
.shopping-icon:before {
  content: "\f290";
  font-family: 'fontAwesome';
  font-size: 15px;
}
.hamburger-icon:before {
  content: "\f0c9";
  font-family: 'fontAwesome';
  font-size: 15px;
}
.hamburger-icon {
  display: none;
}
.input-search {
  position: absolute;
  left: 50%;
  top: 50%;
  transform: translate(-50%, -50%);
  display: flex;
}
.input-search:after {
  content: "\f002";
  font-family: fontAwesome;
  border: 1px solid #242424;
  border-left: none;
  color: #242424;
  padding: 8px 14px;
}
.input-search:hover:after {
  color: #d41217;
}
.input-search:focus {
  border: 1px solid #000000;
}
.nav-icons {
  padding-top: 30px;
  padding-bottom: 30px;
}
input[type="search"] {
  padding: 11px;
  border: 1px solid #000000;
  border-right: none;
  outline: none;
  min-width: 516px;
}
input::placeholder {
  color: #A8A8A5;
  font-size: 14px;
}
.timezone-icons .cross-icon:before {
  content: "\f00d";
  font-family: 'FontAwesome';
  font-size: 14px;
  padding: 0px 3px 0px 0px;
  display: flex;
  align-items: center;
  justify-content: center;
}
.nav-icon {
  color: #242424;
  width: 40px;
  height: 40px;
  display: flex;
  align-items: center;
  justify-content: center;
  border: 1px solid #E6E6E6;
  border-radius: 50%;
}
.nav-icon:before {
  display: flex;
  align-items: center;
  justify-content: center;
}
.nav-icon:hover {
  color: #ffffff;
  background: #d41217;
  border-color: #d41217;
}
.account {
  display: none;
  position: absolute;
  top: 62%;
  z-index: 2;
  font-size: 14px;
  line-height: 14px;
  border: 1px solid #dee8e3;
  padding: 8px 16px;
  width: 100%;
  max-width: 200px;
  background: #ffffff;
}
.account .account-menu {
  padding: 6px 12px;
  background: #d41217;
  border: none;
  color: #ffffff;
  border-radius: 5px;
  text-align: center;
  margin-bottom: 8px;
  width: 100%;
  max-width: 100%;
}
.account .account-menu a {
  border: none;
  color: #ffffff;
  background: none;
  text-decoration: none;
  font-size: 14px;
  line-height: 34px;
}
.account .account-menu:hover {
  background: #8d0c0f;
}
.account-content {
  padding: 16px 0;
  margin-bottom: 4px;
  border-bottom: 1px solid #dee8e3;
}
.account-register {
  border: 1px solid #ffffff;
  background: #ffffff;
  display: flex;
  align-items: center;
  justify-content: center;
  gap: 5px;
  padding-bottom: 4px;
}
.account-register a {
  color: #d41217;
  text-decoration: none;
}
.account-register a:hover {
  text-decoration: underline;
  cursor: pointer;
  color: #8d0c0f;
  border-color: #d41217;
}
a.timezone-text {
  text-decoration: none;
  color: #242424;
  font-size: 13px;
  display: flex;
  gap: 30px;
}
a.timezone-text:after {
  content: "\f063";
  font-family: fontAwesome;
}
.profile-icon:hover .account {
  display: block;
}
.offcanvas-cart {
  transition: all 0.5s ease;
  top: 0px;
  right: -100%;
  position: fixed;
  z-index: 5;
  background: #ffffff;
  display: block;
  height: 100vh;
  width: 100%;
  max-width: 400px;
  overflow: auto;
  padding: 20px;
}
.offcanvas-cart.offcanvas-active {
  right: 0;
}
#scroller {
  background: #ffffff;
}
.stuck {
  position: fixed;
  z-index: 100;
  width: 100%;
  top: 0;
  padding: 5px 100px;
}
.overlay {
  display: none;
  position: fixed;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  width: 100%;
  height: 100vh;
  z-index: 1;
  cursor: pointer;
  background: rgba(0, 0, 0, 0.5);
}
.overlay-active {
  display: block;
}
.offcanvas-cart.offcanvas-active.cross-icon:before {
  position: absolute;
  top: 37px;
}
button.close-btn {
  border: none;
  background: none;
  font-size: 16px;
}
.offcanvas-cart-header {
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding-bottom: 10px;
}
.offcanvas-cart-header .offcanvas-cart-title span {
  font-size: 20px;
  font-family: "Open Sans";
  font-weight: 600;
  line-height: 20px;
  color: #000000;
}
.offcanvas-cart-header .offcanvas-cart-product span {
  font-size: 16px;
  font-family: "Open Sans";
  font-weight: 700;
  color: #798490;
}
.flashbags {
  display: flex;
}
.flashbags .alert-content p {
  background: #e3effa;
  color: #73ade7;
  padding: 10px;
}
.flashbags .info-note {
  color: #ffffff;
  background: #73ade7;
  display: flex;
  align-items: center;
  justify-content: center;
  padding: 0 10px;
}
.row-item img {
  max-width: 84px;
  max-height: 116px;
}
.offcanvas-row {
  display: flex;
  padding: 16px 0;
  border-bottom: 1px solid #E6E6E6;
}
.offcanvas-cart-promotion p {
  font-size: 14px;
  margin-bottom: 16px;
  margin-top: 16px;
}
.form-content {
  display: flex;
}
input[type="text"] {
  padding: 9px;
  background: #ffffff;
  border: none;
  width: 100%;
  border-right: none;
  outline: none;
}
input[type="text"]:hover {
  border-color: #000000;
}
.form-content form {
  width: 100%;
  max-width: 100%;
  border: 1px solid #E6E6E6;
  border-right: none;
}
.form-content form:hover {
  border-color: #000000;
}
button.btn-primary {
  padding: 8px 12px 9px 12px;
  background: #d41217;
  color: #ffffff;
  border: 1px solid #d41217;
  font-size: 14px;
  border-left: none;
}
button.btn-primary:hover {
  background: #8d0c0f;
}
.cart-product-name {
  margin-bottom: 8px;
  padding-top: 8px;
}
.cart-product-name a {
  font-size: 14px;
  color: #242424;
  font-family: "Open Sans";
  font-weight: 700;
}
.cart-product-name a:hover {
  color: #d41217;
  background: none;
}
.cart-item-characteristics {
  display: flex;
  margin: 8px 0;
  gap: 2px;
}
.cart-item-characteristics .card-details span {
  font-size: 12px;
}
.colors {
  font-weight: 700;
  font-family: "Open Sans";
}
.cart-qauntity-price {
  display: flex;
  align-items: center;
  justify-content: space-between;
}
select.quantity {
  padding: 9px 25px 9px 9px;
  border: 1px solid #E6E6E6;
  border-radius: 3px;
  background: #ffffff;
  cursor: pointer;
}
select.quantity:hover {
  border: 1px solid #242424;
}
.cart-item-remove button {
  border: none;
  background: #ffffff;
  font-size: 14px;
  font-family: "Open Sans";
  font-weight: 600;
  color: #d41217;
  cursor: pointer;
  padding: 2px 12px;
}
.cart-item-remove button:hover {
  color: #8d0c0f;
  text-decoration: underline;
}
.cart-item-price span {
  font-size: 14px;
  font-family: "Open Sans";
  font-weight: 700;
}
.btn-primary:after {
  content: "\f00c";
  font-family: fontAwesome;
}
.offcanvas-summary {
  margin: 16px 0;
}
.offcanvas-summary .shipping-info,
.offcanvas-summary .summary-info {
  display: flex;
  align-items: center;
  justify-content: space-between;
  font-size: 14px;
  line-height: 18px;
  font-family: "Open Sans";
  font-weight: 400;
}
.offcanvas-summary .summary-info {
  font-weight: 600;
  font-family: "Open Sans";
}
.summary-info .summary-value {
  font-weight: 400;
  font-family: "Open Sans";
}
p.cart-tax {
  font-size: 14px;
  margin-bottom: 16px;
  line-height: 20px;
  padding-top: 5px;
  color: #798490;
}
button.button-primary:hover {
  background: #8d0c0f;
}
button.button-primary,
.button-secondary {
  display: flex;
  width: 100%;
  max-width: 100%;
  align-items: center;
  justify-content: center;
  padding: 16px 16px;
  color: #ffffff;
  background: #d41217;
  border: 1px solid #d41217;
  border-radius: 4px;
  font-size: 14px;
  font-family: "Open Sans";
  margin-bottom: 10px;
  font-weight: 600;
}
.button-secondary {
  color: #000000;
  background: #E6E6E6;
  border: 1px solid #E6E6E6;
}
.button-secondary:hover {
  background: #d9e6e1;
  border: 1px solid #d9e6e1;
}
.main-section {
  position: relative;
}
.banner img {
  width: 100%;
}
.banner-title {
  position: absolute;
  top: 50%;
  transform: translateY(-50%);
  right: 0;
}
.banner-summer-title,
.banner-winter-title {
  border: 1px solid #f6f6f6;
  padding: 49px 80px ;
  background-color: #A8A8A5;
  margin: 10px;
  opacity: 65%;
  color: #FBFBFB;
}
.brand-name {
  font-size: 17px;
  display: block;
  text-align: center;
}
.collectionyear {
  font-size: 30px;
}
.category-section {
  display: flex;
  margin-top: 10px;
  opacity: 100%;
}
.category-female {
  margin-right: 10px;
}
.fitguide-section {
  display: flex;
  margin-top: 10px;
}
.fitguide {
  padding: 80px 80px;
  color: #f6f6f6;
  background-color: #f6f6f6;
  flex: 1;
}
.fitguide span {
  color: #242424;
  display: flex;
  align-items: center;
  justify-content: center;
}
.s-fit {
  font-size: 24px;
}
.fit {
  font-size: 50px;
}
.damen {
  margin-right: 10px;
}
.timezone-products {
  margin-top: 91px;
}
.product-content-title {
  background: #f6f6f6;
  padding: 21px 0;
  text-align: center;
  margin-bottom: 47px;
}
.product-content-title strong {
  font-size: 22px;
  color: #242424;
  line-height: 22px;
  text-transform: uppercase;
}
.timezone-mode-online .product-content-title {
  margin-top: 106px;
}
.instagram .product-content-title {
  margin-top: 87px;
}
.timezone-product-detail {
  display: flex;
  align-items: center;
  justify-content: center;
  gap: 130px;
  margin-bottom: 144px;
}
.product-name {
  margin-bottom: 20px;
}
.product-name span {
  font-size: 14px;
}
.product-item {
  margin-bottom: 24px;
}
.product-item span {
  font-size: 20px;
  display: block;
}
.product-price span {
  font-size: 17px;
}
.product-price .price {
  color: #d41217;
}
.product-brand {
  font-size: 11px;
  margin-bottom: 30px;
}
.product-Größe {
  margin-bottom: 15px;
}
.product-Größe span {
  font-size: 14px;
}
.full-productdetail {
  margin-top: 45px;
}
.full-productdetail span {
  font-size: 14px;
  text-decoration: underline;
  text-transform: uppercase;
}
.product-size {
  display: flex;
  gap: 17px;
  margin-bottom: 30px;
}
.product-size a {
  color: #242424;
  text-decoration: none;
  border: 1px solid #242424;
  display: flex;
  align-items: center;
  padding: 11px 12px 10px 13px;
}
.product-content span {
  border: 1px solid transparent;
  background: #00000029;
  padding: 16px 16px;
  box-shadow: 0px 3px 6px #9D9D9D;
  display: block;
  font-size: 12px;
}
.timezone-section-one {
  text-align: end;
}
.timezone-section-one .product-size {
  justify-content: right;
}
.sale-product {
  position: relative;
}
.sale-product button {
  position: absolute;
  left: 0;
  top: 0px;
  margin-top: 8px;
  margin-left: 8px;
  color: #d41217;
  border: transparent;
  font-size: 9px;
}
.timezone-product-images {
  display: flex;
  gap: 40px;
  padding: 0px 20px;
}
.product-subimage {
  position: relative;
}
.sub-images {
  position: absolute;
  left: 50%;
  transform: translateX(-50%);
  bottom: -50px;
  display: flex;
  gap: 6px;
  width: 100%;
  justify-content: center;
  display: none;
}
.product-subimage .product-details {
  margin-top: 50px;
}
.product-details span {
  font-size: 13px;
  line-height: 13px;
  display: flex;
  align-items: center;
  justify-content: center;
  padding-bottom: 10px;
  text-transform: uppercase;
}
.timezone-content .product-details {
  margin-top: 50px;
}
.star:after {
  content: "\f005";
  font-family: fontAwesome;
}
.stars {
  text-align: center;
}
.color {
  color: #d41217;
}
.product-zum {
  padding-top: 22px;
  line-height: 16px;
  text-align: center;
}
.product-zum span {
  border: 1px solid transparent;
  background: #00000029;
  padding: 16px 16px;
  box-shadow: 0px 3px 6px #9D9D9D;
  font-size: 12px;
  text-transform: uppercase;
  display: inline-block;
}
.timezone-icons.product-icons {
  margin-top: 22px;
  display: flex;
  align-items: center;
  justify-content: center;
}
.timezone-content {
  border: 1px solid transparent;
  padding: 16px;
  position: relative;
  border-bottom: none;
  background-color: #ffffff;
}
.timezone-content:hover {
  display: block;
  border: 1px solid #9D9D9D;
  padding: 16px;
  border-bottom: none;
}
.timezone-content:hover .timezone-product-content-details {
  display: block;
  position: absolute;
  border: 1px solid #9D9D9D;
  width: calc(100% + 2px);
  left: -1px;
  top: 100%;
  border-top: none;
  padding-bottom: 10px;
  background-color: #ffffff;
}
.product-sale-section {
  display: flex;
  flex-wrap: wrap;
  max-width: 100%;
  margin: 0 ;
  margin-top: 109px;
}
.row {
  display: flex;
  flex-wrap: wrap;
}
.section-image {
  width: 50%;
  padding: 5px;
}
.section-image img {
  max-width: 100%;
}
.timezone-content:hover .timezone-product-content-details {
  display: block;
}
.timezone-content:hover .sub-images {
  display: flex;
  margin-bottom: 10px;
}
.timezone-product-content-details {
  display: none;
}
.section-image {
  position: relative;
}
.section-image span {
  font-size: 120px;
  position: absolute;
  top: 50%;
  z-index: 1;
  left: 50%;
  transform: translate(-50%, -50%);
  color: #d41217;
  letter-spacing: 50px;
  box-shadow: 0px 0px 0px #d41217;
}
.area-tag::after {
  content: "\f3c5";
  font-family: fontAwesome;
}
.timezone-form {
  position: absolute;
  top: 50%;
  transform: translateY(-50%);
  display: flex;
  flex-wrap: wrap;
  align-items: center;
  justify-content: center;
}
.timezone-form h6 {
  font-size: 13px;
  color: #242424;
  padding-bottom: 23px;
}
.timezone-form p {
  color: #242424;
  font-size: 20px;
  text-transform: uppercase;
  line-height: 17px;
  padding-bottom: 38px;
}
.timezone-form h7 {
  font-size: 14px;
  line-height: 14px;
  padding-top: 17px;
  color: #242424;
}
.timezone-filldetail button {
  background: #d41217;
  padding: 22px 72px 21px 72px;
  border: transparent;
  box-shadow: 0px 2px 3px #9D9D9D;
  color: #ffffff;
  font-size: 15px;
}
input#email {
  padding: 20px 80px 21px 21px;
}
.instagram-shot {
  display: flex;
  gap: 21px;
  padding: 0 145px;
}
.instagram-images img {
  overflow: auto;
}
.social-media {
  margin-top: 50px;
  text-transform: uppercase;
  font-size: 13px;
  color: #242424;
  padding-left: 145px;
}
.social-links {
  margin-top: 15px;
}
.social-links .fb-icon:after {
  content: "\f09a";
  font-family: fontAwesome;
}
.social-links .instgram-icon:after {
  content: "\f16d";
  font-family: fontAwesome;
}
.mode-online-content {
  max-width: 65%;
  display: flex;
  gap: 50px;
  margin: 0 auto;
}
.mode-online-content p {
  font-size: 14px;
}
.footer-section {
  margin-top: 87px;
}
.footer-timezone {
  display: flex;
  gap: 28px;
  padding: 57px 145px 29px 145px;
}
.footer-details {
  display: flex;
  gap: 28px;
}
.input-search {
  display: none;
}
.input-search.\.input-active {
  display: flex;
}
@media screen and (min-width: 1025px) {
  input[type="search"] {
    min-width: 516px;
  }
}
@media screen and (max-width: 1024px) {
  .hamburger-icon {
    display: flex;
    align-items: center;
    justify-content: center;
  }
  .nav-section {
    padding: 5px 35px;
    transition: padding 0.5s;
  }
  .stuck {
    padding: 5px 50px;
  }
  .account {
    top: 68%;
  }
  .nav-menu {
    display: none;
  }
  .input-search {
    display: flex;
    left: 40%;
  }
  input[type="search"] {
    min-width: 400px;
  }
  .input-search.\.input-active {
    display: flex;
  }
  .nav-menu.nav-active {
    display: block;
    position: fixed;
    left: 0;
    width: 30%;
    background: #ffffff;
    height: 100%;
    top: 0;
    z-index: 2;
  }
  li.navigation-col {
    padding: 0;
  }
  .main-menu {
    transform: translateX(0) !important;
  }
}
