import { toast } from "react-toastify";

toast.configure({
  autoClose: 3000,
  draggable: false,
  position: "top-right",
  hideProgressBar: false,
  newestOnTop: true,
  closeOnClick: true,
  rtl: false,
  pauseOnHover: true
});

export default toast;