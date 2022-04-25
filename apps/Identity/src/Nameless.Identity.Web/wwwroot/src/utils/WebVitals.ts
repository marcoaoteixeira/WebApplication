import { ReportHandler } from 'web-vitals';

export const WebVitals = {
  Report(handler?: ReportHandler) {
    if (handler && handler instanceof Function) {
      import('web-vitals').then(({ getCLS, getFID, getFCP, getLCP, getTTFB }) => {
        getCLS(handler);
        getFID(handler);
        getFCP(handler);
        getLCP(handler);
        getTTFB(handler);
      });
    }
  }
};
