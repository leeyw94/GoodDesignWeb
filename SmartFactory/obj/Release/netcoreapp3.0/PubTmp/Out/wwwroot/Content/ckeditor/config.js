/**
 * @license Copyright (c) 2003-2015, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see LICENSE.md or http://ckeditor.com/license
 */

CKEDITOR.editorConfig = function (config) {
    // Define changes to default configuration here. For example:
    // config.language = 'fr';
    // config.uiColor = '#AADC6E';


    config.toolbar = [



	['Bold', 'Italic', 'Underline', 'Strike', '-'], ['NumberedList', 'BulletedList', '-', 'Blockquote'], ['JustifyLeft', 'JustifyCenter', 'JustifyRight', 'JustifyBlock'],
	['Image', 'Table'], ['Font', 'FontSize'], ['TextColor', 'BGColor']];

    config.language = 'ko';			//����
    config.uiColor = '#EEEEEE';		//ui ����
    config.height = '300px';		//Editor ����  
    config.width = '100%';			//Editor ����
    config.contentsCss = ['/content/sub.css'];	//Ȩ���������� ����ϴ� Css ���� ��Ŭ���
    config.font_defaultLabel = 'Gulim';
    config.font_names = 'Gulim;Dotum/Dotum;Batang/Batang;Gungsuh/Gungsuh/Arial/Arial;Tahoma/Tahoma;Verdana/Verdana';
    config.fontSize_defaultLabel = '12px';
    config.fontSize_sizes = '8/8px;9/9px;10/10px;11/11px;12/12px;14/14px;16/16px;18/18px;20/20px;22/22px;24/24px;26/26px;28/28px;36/36px;48/48px;';
    config.enterMode = CKEDITOR.ENTER_BR;		//����Ű �Է½� br �±� ����
    config.shiftEnterMode = CKEDITOR.ENTER_P;	//����Ű �Է½� p �±׷� ����
    config.startupFocus = true;					// ���۽� ��Ŀ�� ����
    config.allowedContent = true;				// �⺻���� html�� ���͸����� �������µ� ���͸��� ���� �ʴ´�.
    //config.filebrowserImageUploadUrl = '/include/editor/upload/upload.asp';		//�̹��� ���ε� ��� (�����ϸ� ���ε� �÷����ο� ���̻���)

    config.toolbarCanCollapse = true;		//���ٰ� ������ ����� ������ ����մϴ�.
    config.docType = "<!DOCTYPE html>";		//����Ÿ�� ����

    config.extraAllowedContent = 'video[*]{*};source[*]{*}';		//video , embed �� ���� �±׸� ����ϰ� �ϴ� ����


};
